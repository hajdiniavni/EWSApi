using EWSAPI.Controllers;
using EWSApi.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Newtonsoft.Json;

using EWSApi.Models.HealthInstitution;
using EWSApi.Models.Examination;
using EWSApi.Models.MedicalStaff;
using EWSApi.Models.ReportRegister;
using EWSApi.Models.DiseaseInfection;
using System.Data.Common;
using System.Transactions;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace EWSApi.Controllers
{
    [Route("api/[controller]"), Authorize]
    [ApiController]
    public class SMSNController : Controller
    {
        private IConfiguration _conf;
        private readonly LogService _logService;
        private readonly EwsContext _context;
        private readonly AppDBContext _sqlContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SMSNController(EwsContext context, AppDBContext sqlContext, LogService logService, IHttpContextAccessor httpContextAccessor, IConfiguration conf)
        {
            this._context = context;
            this._sqlContext = sqlContext;
            _conf = conf;
            this._logService = logService;
            this._httpContextAccessor = httpContextAccessor;
        }


        // GET: api/SMSN/GetLabData/578
        
        [HttpGet("GetLabData/{UniqueNumber}")]
        public async Task<ActionResult<IEnumerable<object>>> GetLabData([FromRoute] LabDataRequestModel requestModel)//(string UniqueNumber, string LabCode)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;


            if (_context.ReportRegister == null)
            {
                 _logService.InsertLog(currentHttpContext, "GetLabData", "Nuk u gjet asnje me keto UniqueNumber= " + requestModel.UniqueNumber + ", Accepted date= " + DateTime.Now.ToString() + "", true);
                return NotFound();
            }

            var excludedReportRegisterTestIds = _context.ReportRegisterTestResult
    .Select(rrtr => rrtr.ReportRegisterTestId)
    .ToHashSet();


            var result = await (from rr in _context.ReportRegister
                                join cr in _context.CitizenRegister on rr.CitizenRegisterId equals cr.CitizenRegisterId
                                join c in _context.Country on cr.CountryId equals c.CountryId
                                join rrs in _context.ReportRegisterStatus
                                     on new { rr.ReportRegisterId, Active = true } equals new { rrs.ReportRegisterId, rrs.Active }
                                join ms in _context.MedicalStaff on rrs.MedicalStaffId equals ms.MedicalStaffId into medicalStaff
                                     from staff in medicalStaff.DefaultIfEmpty() // Left Join
                                join rrt in _context.ReportRegisterTest on rr.ReportRegisterId equals rrt.ReportRegisterId
                                join e in _context.Examination on rrt.ExaminationId equals e.ExaminationId into testTypes
                                where (rr.UniqueNumber == requestModel.UniqueNumber) || (cr.PersonalNumber == AesCrypto.Ecrypt<string>(requestModel.UniqueNumber)) // Assuming personalNumberParameter is the parameter for @PersonalNumber
                                select new
                                {
                                    UniqueNumberSMSN = rr.UniqueNumber,
                                    PersonalNumber = AesCrypto.Decrypt<string>(cr.PersonalNumber),
                                    rr.HealthInstitutionName,
                                    rr.HealthInstitutionAddress,
                                    Name = AesCrypto.Decrypt<string>(cr.Firstname),
                                    ParentName = AesCrypto.Decrypt<string>(cr.FatherName),
                                    Surname = AesCrypto.Decrypt<string>(cr.Lastname),
                                    Address = $"{c.NameSq}, {AesCrypto.Decrypt<string>(cr.Municipality)}, {AesCrypto.Decrypt<string>(cr.Address)}",
                                    Doctor = (staff == null) ? null : $"{staff.Firstname} {staff.Lastname} - {staff.LicenceNumber}",
                                    TestTypes = testTypes
                                               .Where(tt => tt != null && !excludedReportRegisterTestIds.Contains(rrt.ReportRegisterTestId))
                                               .Select(tt => new {ReportRegisterTestID = rrt.ReportRegisterTestId, TestID= tt.ExaminationId, TestNumber = tt.ExaminationCode, Description = tt.ExaminationName })
                                               .Distinct()
                                               .ToList(),

                                }).GroupBy(x => x.UniqueNumberSMSN)
                                  .Select(group => new
                                   {
                                       UniqueNumberSMSN = group.Key,
                                       PersonalNumber = group.First().PersonalNumber,
                                       HealthInstitutionName = group.First().HealthInstitutionName,
                                       HealthInstitutionAddress  = group.First().HealthInstitutionAddress,
                                       Name = group.First().Name,
                                       ParentName = group.First().ParentName,
                                       Surname = group.First().Surname,
                                       Address = group.First().Address,
                                       Doctor = group.First().Doctor,
                                       TestTypes = group.SelectMany(x => x.TestTypes).Distinct().ToList(),
                                  })
                                  .ToListAsync();


            _logService.InsertLog(currentHttpContext, "GetLabData", "UniqueNumber= " + requestModel.UniqueNumber + ", Accepted date= " + DateTime.Now.ToString() + "", false);




            if (result == null || result.Count == 0)
            {
                 _logService.InsertLog(currentHttpContext, "GetLabData", "Nuk u gjet asnje me keto UniqueNumber= " + requestModel.UniqueNumber + ", Accepted date= " + DateTime.Now.ToString() + "", true);
                return NotFound();

            }

            return Ok(result);
        }



        // POST: api/PostMedicalStaff
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        
        [HttpPost("PostMedicalStaff")]
        public async Task<ActionResult<MedicalStaffVM>> PostMedicalStaff(MedicalStaffVM medicalStaff)
        {

            var currentHttpContext = _httpContextAccessor.HttpContext;
            var transaction = _context.Database.BeginTransaction();
            string jsonMedicalStaff = JsonConvert.SerializeObject(medicalStaff);
            try
            {
              

                var existingMedicalStaff = await _context.MedicalStaff
                  .FirstOrDefaultAsync(ms => ms.PersonalNumber == medicalStaff.PersonalNumber && ms.LicenceNumber == medicalStaff.LicenceNumber);

                if (existingMedicalStaff == null)
                {
                    // Create new medical staff
                    _context.MedicalStaff.Add(new MedicalStaff
                    {
                        PersonalNumber = medicalStaff.PersonalNumber,
                        LicenceNumber = medicalStaff.LicenceNumber,
                        Firstname = medicalStaff.Firstname,
                        Lastname = medicalStaff.Lastname,
                        Specialization = medicalStaff.Specialization,
                        Status = medicalStaff.Status,
                        InsertedDate = DateTime.Now,
                        InsertedFrom = _conf["Jwt:UserID"].ToString()
                    }


                    );

                    await _context.SaveChangesAsync();
                     jsonMedicalStaff = JsonConvert.SerializeObject(medicalStaff);
                    transaction.Commit();
                    _logService.InsertLog(currentHttpContext, "PostMedicalStaff", "MedicalStaff created: " + jsonMedicalStaff + "", false);
                }
                else
                {
                    // Update existing medical staff

                    existingMedicalStaff.Firstname = medicalStaff.Firstname;
                    existingMedicalStaff.Lastname = medicalStaff.Lastname;
                    existingMedicalStaff.Specialization = medicalStaff.Specialization;
                    existingMedicalStaff.Status = medicalStaff.Status;
                    existingMedicalStaff.UpdatedDate = DateTime.Now;
                    existingMedicalStaff.UpdatedFrom = _conf["Jwt:UserID"];

                    await _context.SaveChangesAsync();
                    
                    transaction.Commit();
                    _logService.InsertLog(currentHttpContext, "PostMedicalStaff", "MedicalStaff updated: " + jsonMedicalStaff + "", false);
                }



                return Ok(new { Message = "Success" });
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                _logService.InsertLog(currentHttpContext, "PostMedicalStaff", "An error occurred while processing the request MedicalStaff :" + ex.InnerException.ToString() + " " + jsonMedicalStaff, true);
                return BadRequest(new { Message = ex.InnerException.ToString() });
            }
        }



        //POST: api/PostExamination
        //To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        
        [HttpPost("PostExamination")]
        public async Task<ActionResult<ExaminationVM>> PostExamination(ExaminationVM examination)
        {

            var currentHttpContext = _httpContextAccessor.HttpContext;
            var transaction = _context.Database.BeginTransaction();
            string jsonExamination = JsonConvert.SerializeObject(examination);
            try
            {
              
                var existingExamination = await _context.Examination
                  .FirstOrDefaultAsync(ms => ms.ExaminationId == examination.ExaminationId);

                if (existingExamination == null)
                {
                    // Create new Examination
                    _context.Examination.Add(new Examination
                    {
                        ExaminationId = examination.ExaminationId,
                        ExaminationName = examination.ExaminationName,
                        ExaminationCode = examination.ExaminationCode,
                        IsEpidemic = examination.IsEpidemic,
                        ResultTime = examination.ResultTime,
                        LocalPrice = examination.LocalPrice,
                        ForeignPrice = examination.ForeignPrice,
                        Active = examination.Active,
                        IsDynamic = examination.IsDynamic,
                        InsertedDate = DateTime.Now,
                        InsertedFrom = _conf["Jwt:UserID"].ToString()
                    }


                    );

                    await _context.SaveChangesAsync();
                     jsonExamination = JsonConvert.SerializeObject(examination);
                    transaction.Commit();
                    _logService.InsertLog(currentHttpContext, "PostExamination", "Examination created: " + jsonExamination + "", false);
                }
                else
                {
                    // Update existingExamination

                    existingExamination.ExaminationName = examination.ExaminationName;
                    existingExamination.ExaminationCode = examination.ExaminationCode;
                    existingExamination.IsEpidemic = examination.IsEpidemic;
                    existingExamination.ResultTime = examination.ResultTime;
                    existingExamination.LocalPrice = examination.LocalPrice;
                    existingExamination.ForeignPrice = examination.ForeignPrice;
                    existingExamination.Active = examination.Active;
                    existingExamination.IsDynamic = examination.IsDynamic;
                    existingExamination.UpdatedDate = DateTime.Now;
                    existingExamination.UpdatedFrom = _conf["Jwt:UserID"];

                    await _context.SaveChangesAsync();
             
                    transaction.Commit();
                    _logService.InsertLog(currentHttpContext, "PostExamination", "Examination updated: " + jsonExamination + "", false);
                }



                return Ok(new { Message = "Success" });
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                _logService.InsertLog(currentHttpContext, "PostExamination", "An error occurred while processing the request Examination :" + ex.InnerException.ToString() + " " + jsonExamination, true);
                return BadRequest(new { Message = ex.InnerException.ToString() });
            }
        }



        //POST: api/PostHealthInstitution
        //To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        
        [HttpPost("PostHealthInstitution")]
        public async Task<ActionResult<HealthInstitutionVM>> PostHealthInstitution(HealthInstitutionVM healthInstitution)
        {

            var currentHttpContext = _httpContextAccessor.HttpContext;
            var transaction = _context.Database.BeginTransaction();
            string jsonHealthInstitution = JsonConvert.SerializeObject(healthInstitution);
            try
            {



                var existingHealthInstitution = await _context.HealthInstitution
                  .FirstOrDefaultAsync(ms => ms.IdentificationNumber == healthInstitution.IdentificationNumber && ms.LicenceNumber == healthInstitution.LicenceNumber);

                if (existingHealthInstitution == null)
                {
                    // Create new HealthInstitution
                    _context.HealthInstitution.Add(new HealthInstitution
                    {
                        HealthInstitutionLevelId = healthInstitution.HealthInstitutionLevelId,
                        IdentificationNumber = healthInstitution.IdentificationNumber,
                        LicenceNumber = healthInstitution.LicenceNumber,
                        NameSq = healthInstitution.NameSq,
                        NameEn = healthInstitution.NameEn,
                        NameSr = healthInstitution.NameSr,
                        ShortNameSq = healthInstitution.ShortNameSq,
                        ShortNameEn = healthInstitution.ShortNameEn,
                        ShortNameSr = healthInstitution.ShortNameSr,
                        Description = healthInstitution.Description,
                        MinicipalityId = healthInstitution.MinicipalityId,
                        SettlementId = healthInstitution.SettlementId,
                        Address = healthInstitution.Address,
                        Status = healthInstitution.Status,
                        EmailAddress = healthInstitution.EmailAddress,
                        PhoneNumber = healthInstitution.PhoneNumber,
                        InsertedDate = DateTime.Now,
                        InsertedFrom = _conf["Jwt:UserID"].ToString()
                    }


                    );

                    await _context.SaveChangesAsync();
                     jsonHealthInstitution = JsonConvert.SerializeObject(healthInstitution);
                    transaction.Commit();
                    _logService.InsertLog(currentHttpContext, "PostHealthInstitution", "healthInstitution created: " + jsonHealthInstitution + "", false);
                }
                else
                {
                    // Update existingHealthInstitution
                    existingHealthInstitution.HealthInstitutionLevelId = healthInstitution.HealthInstitutionLevelId;
                    existingHealthInstitution.NameSq = healthInstitution.NameSq;
                    existingHealthInstitution.NameEn = healthInstitution.NameEn;
                    existingHealthInstitution.NameSr = healthInstitution.NameSr;
                    existingHealthInstitution.ShortNameSq = healthInstitution.ShortNameSq;
                    existingHealthInstitution.ShortNameEn = healthInstitution.ShortNameEn;
                    existingHealthInstitution.ShortNameSr = healthInstitution.ShortNameSr;
                    existingHealthInstitution.Description = healthInstitution.Description;
                    existingHealthInstitution.MinicipalityId = healthInstitution.MinicipalityId;
                    existingHealthInstitution.SettlementId = healthInstitution.SettlementId;
                    existingHealthInstitution.Address = healthInstitution.Address;
                    existingHealthInstitution.Status = healthInstitution.Status;
                    existingHealthInstitution.EmailAddress = healthInstitution.EmailAddress;
                    existingHealthInstitution.PhoneNumber = healthInstitution.PhoneNumber;
                    existingHealthInstitution.UpdatedDate = DateTime.Now;
                    existingHealthInstitution.UpdatedFrom = _conf["Jwt:UserID"];

                    await _context.SaveChangesAsync();
                   
                    transaction.Commit();
                    _logService.InsertLog(currentHttpContext, "PostHealthInstitution", "healthInstitution updated: " + jsonHealthInstitution + "", false);
                }



                return Ok(new { Message = "Success" });

            }

            catch (Exception ex)
            {

                transaction.Rollback();
                _logService.InsertLog(currentHttpContext, "PostHealthInstitution", "An error occurred while processing the request healthInstitution :" + ex.InnerException.ToString() + " " + jsonHealthInstitution, true);
                return BadRequest(new { Message = ex.InnerException.ToString() });
            }

        
        }
        bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Simple email regex pattern
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }


        //POST: api/PostHealthInstitution
        //To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPost("PostReportRegister")]
        public async Task<ActionResult<ReportRegisterVM>> PostReportRegister([FromBody] ReportRegisterVM reportRegister)
        {
         
            var transaction = _context.Database.BeginTransaction();
                var currentHttpContext = _httpContextAccessor.HttpContext;
            string json = JsonConvert.SerializeObject(reportRegister);

            if (!ModelState.IsValid)
            {
                transaction.Rollback();
                _logService.InsertLog(currentHttpContext, "PostReportRegister", ModelState + " " + json, true);
                return BadRequest(ModelState); // or return a custom validation response
            }

            try
            {


                    int healthInstitutionID = 0;

                    string uniqueNumber = _sqlContext.GenerateUniqueNumber.FromSqlInterpolated($"select   dbo.GenerateUniqueNumber (1) as uniqueNumber").FirstOrDefault().uniqueNumber;

                    if (int.TryParse(reportRegister.HealthInstitutionIdentificationNumber, out int institutionId))
                    {
                        healthInstitutionID = await _context.HealthInstitution
                           .Where(ms => ms.Bhisid == institutionId)
                           .Select(ms => ms.HealthInstitutionId)
                           .FirstOrDefaultAsync();
                    }
                    else
                    {
                        // Handle parsing failure, possibly logging or throwing a more specific exception
                    }
                //                if (!string.IsNullOrWhiteSpace(reportRegister.Email) &&
                //!Regex.IsMatch(reportRegister.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                //                {
                //                    transaction.Rollback();
                //                    _logService.InsertLog(currentHttpContext, "PostReportRegister", "Email format is invalid." + json, true);
                //                    return BadRequest(new { Message = "Email format is invalid." });
                //                }

                if (reportRegister.caseClassification.Any(cc => cc.CaseClassificationTypeId == 0))
                {
                    transaction.Rollback();
                    _logService.InsertLog(currentHttpContext, "PostReportRegister", "CaseClassificationTypeId është i pavlefshëm" + json, true);
                    return BadRequest(new { Message = "CaseClassificationTypeId është i pavlefshëm." });
                }

                // kushti eshte bart lart, qe me kontrollu a ka raportim per ate semundje.
                var diseaseInfectionIds = _context.DiseaseInfection
                              .Select(ms => new { DiseaseCode = ms.DiseaseCode.Trim(), ms.DiseaseInfectionId })
                              .Where(ms => reportRegister.caseClassification
                                  .Select(cc => cc.DiseaseInfectionId.Trim()).Contains(ms.DiseaseCode))
                              .ToDictionary(ms => ms.DiseaseCode, ms => ms.DiseaseInfectionId);

                if (diseaseInfectionIds == null)
                {
                    _logService.InsertLog(currentHttpContext, "PostReportRegister", "Nuk u gjet asnje diseaseInfectionIds me keto parametra: " + json + "", false);
                    return Ok(new { Message = "Nuk u gjet asnje diseaseInfectionIds me keto parametra" });
                }
                var infectionIds = diseaseInfectionIds.Values.ToList();
                var hasReport = await _context.ReportRegister.Where(e => e.PersonalNumber == reportRegister.PersonalNumber && e.ReportRegisterStatus.Any(e => e.Active)
                                        && e.ReportRegisterCaseClassification.Any(a => a.Active == true && infectionIds.Contains(a.DiseaseInfectionId))
                                        && e.InsertedDate.Date == DateTime.Now.Date && e.InsertedFrom == _conf["Jwt:UserID"].ToString()).AnyAsync();

                if (hasReport)
                {
                    transaction.Rollback();
                    _logService.InsertLog(currentHttpContext, "PostReportRegister", "Personi me numer personal:" + reportRegister.PersonalNumber + " eshte raportuar!" + json, true);
                    return BadRequest(new { Message = "Personi me numer personal:" + reportRegister.PersonalNumber + " eshte raportuar!" });
                }


                int citizenRegisterID = await _context.CitizenRegister
                   .Where(ms => ms.PersonalNumber == AesCrypto.Ecrypt<string>(reportRegister.PersonalNumber))
                   .Select(ms => ms.CitizenRegisterId)
                   .FirstOrDefaultAsync();

                    int medicalStaffID = await _context.MedicalStaff
                   .Where(ms => ms.PersonalNumber == reportRegister.MedicalPersonalNumber)// && ms.LicenceNumber == reportRegister.MedicalLicenseNumber)
                   .Select(ms => ms.MedicalStaffId)
                   .FirstOrDefaultAsync();

                    if (reportRegister?.caseClassification == null || !reportRegister.caseClassification.Any())
                    {
                        transaction.Rollback();
                        _logService.InsertLog(currentHttpContext, "PostReportRegister", "caseClassification është i detyrueshëm" + json, true);
                        return BadRequest(new { Message = "caseClassification është i detyrueshëm." });
                    }

                    // ✅ Validate if any CaseClassificationTypeId is invalid
                    if (reportRegister.caseClassification.Any(cc => cc.CaseClassificationTypeId == 0))
                    {
                        transaction.Rollback();
                        _logService.InsertLog(currentHttpContext, "PostReportRegister", "CaseClassificationTypeId është i pavlefshëm" + json, true);
                        return BadRequest(new { Message = "CaseClassificationTypeId është i pavlefshëm." });
                    }

          //          var diseaseInfectionIds = _context.DiseaseInfection
          //.Select(ms => new { DiseaseCode = ms.DiseaseCode.Trim(), ms.DiseaseInfectionId })
          //.Where(ms => reportRegister.caseClassification
          //    .Select(cc => cc.DiseaseInfectionId.Trim()).Contains(ms.DiseaseCode))
          //.ToDictionary(ms => ms.DiseaseCode, ms => ms.DiseaseInfectionId);


                    if (healthInstitutionID == null || healthInstitutionID == 0)
                    {
                        _logService.InsertLog(currentHttpContext, "PostReportRegister", "Nuk u gjet asnje institucion shendetesor me keto parametra: " + json + "", false);
                        return Ok(new { Message = "Nuk u gjet asnje institucion shendetesor me keto parametra" });
                    }
                    if (medicalStaffID == null || medicalStaffID == 0)
                    {
                        _logService.InsertLog(currentHttpContext, "PostReportRegister", "Nuk u gjet asnje personel mjekesore me keto parametra: " + json + "", false);
                        return Ok(new { Message = "Nuk u gjet asnje personel mjekesore me keto parametra" });
                    }

                    if (diseaseInfectionIds == null)
                    {
                        _logService.InsertLog(currentHttpContext, "PostReportRegister", "Nuk u gjet asnje diseaseInfectionIds me keto parametra: " + json + "", false);
                        return Ok(new { Message = "Nuk u gjet asnje diseaseInfectionIds me keto parametra" });
                    }

                    if (citizenRegisterID == null || citizenRegisterID == 0)
                    {
                        var newCitizen = new CitizenRegister
                        {
                            PersonalNumber = AesCrypto.Ecrypt<string>(reportRegister.PersonalNumber),
                            Firstname = AesCrypto.Ecrypt<string>(reportRegister.Firstname),
                            Lastname = AesCrypto.Ecrypt<string>(reportRegister.Lastname),
                            FatherName = AesCrypto.Ecrypt<string>(reportRegister.FatherName),
                            MotherName = AesCrypto.Ecrypt<string>(reportRegister.MotherName),
                            PartnerName = AesCrypto.Ecrypt<string>(reportRegister.PartnerName),
                            GenderId = reportRegister.Gender == "M" ? 1 : 2,
                            Birthdate = AesCrypto.Ecrypt<string>(DateTime.ParseExact(reportRegister.Birthdate, "yyyy-MM-ddTHH:mm:ss.fffZ", null).ToString("dd/MM/yyyy")),
                            LivingStatus = reportRegister.LivingStatus,
                            MaritalStatusId = reportRegister.MaritalStatusId,
                            Foreign = reportRegister.Foreign,
                            CountryId = reportRegister.CountryId,
                            MunicipalityId = reportRegister.MunicipalityId,
                            Municipality = AesCrypto.Ecrypt<string>(reportRegister.Municipality),
                            SettlementId = reportRegister.SettlementId,
                            Settlement = AesCrypto.Ecrypt<string>(reportRegister.Settlement),
                            Address = AesCrypto.Ecrypt<string>(reportRegister.Address),
                            BirthPlace = AesCrypto.Ecrypt<string>(reportRegister.BirthPlace),
                            PhoneNumber = AesCrypto.Ecrypt<string>(Regex.Replace(reportRegister.PhoneNumber, @"\D", "")),
                            Email = AesCrypto.Ecrypt<string>(IsValidEmail(reportRegister.Email) ? reportRegister.Email : null),
                            InsertedFrom = _conf["Jwt:UserID"].ToString(),
                            InsertedDate = DateTime.Now



                        };

                        _context.CitizenRegister.Add(newCitizen);
                        await _context.SaveChangesAsync();
                        citizenRegisterID = newCitizen.CitizenRegisterId;

                    }

                    int actualYear = Age(DateTime.Parse(reportRegister.Birthdate), DateTime.Now);
                    var newResportRegister = new ReportRegister
                    {
                        UniqueNumber = uniqueNumber,
                        HealthInstitutionId = healthInstitutionID,
                        HealthInstitutionName = reportRegister.HealthInstitutionName,
                        HealthInstitutionAddress = reportRegister.HealthInstitutionAddress,
                        CitizenRegisterId = citizenRegisterID,
                        PersonalNumber = AesCrypto.Ecrypt<string>(reportRegister.PersonalNumber),
                        Firstname = AesCrypto.Ecrypt<string>(reportRegister.Firstname),
                        Lastname = AesCrypto.Ecrypt<string>(reportRegister.Lastname),
                        FatherName = AesCrypto.Ecrypt<string>(reportRegister.FatherName),
                        MotherName = AesCrypto.Ecrypt<string>(reportRegister.MotherName),
                        PartnerName = AesCrypto.Ecrypt<string>(reportRegister.PartnerName),
                        GenderId = reportRegister.Gender == "M" ? 1 : 2,
                        Birthdate = AesCrypto.Ecrypt<string>(DateTime.ParseExact(reportRegister.Birthdate, "yyyy-MM-ddTHH:mm:ss.fffZ", null).ToString("dd/MM/yyyy")),
                        ActualYear = actualYear,
                        Address = AesCrypto.Ecrypt<string>(reportRegister.Address),
                        PhoneNumber = AesCrypto.Ecrypt<string>(Regex.Replace(reportRegister.PhoneNumber, @"\D", "")),
                        ConsultingDate = reportRegister.ConsultingDate,
                        SyndromeTypeId = reportRegister.SyndromeTypeId,
                        SymptomDate = reportRegister.SymptomDate,
                        SuspectedPlaceTypeId = reportRegister.SuspectedPlaceTypeID,
                        SuspectedPlace = reportRegister.SuspectedPlace,
                        InsertedDate = DateTime.Now,
                        InsertedFrom = _conf["Jwt:UserID"].ToString()

                    };
                    _context.ReportRegister.Add(newResportRegister);
                    await _context.SaveChangesAsync();
                    int ResportRegisterID = newResportRegister.ReportRegisterId;


                    var newReportRegisterSampleTaken = reportRegister.reportRegisterSampleTaken?
             .Select(sample => new ReportRegisterSampleTaken
             {
                 ReportRegisterId = ResportRegisterID,
                 SampleTakenTypeId = (int)sample.SampleTakenTypeId,
                 Active = true,
                 InsertedDate = DateTime.Now,
                 InsertedFrom = _conf["Jwt:UserID"].ToString()
             }).ToList() ?? new List<ReportRegisterSampleTaken>();

                    if (newReportRegisterSampleTaken.Any())
                    {
                        _context.ReportRegisterSampleTaken.AddRange(newReportRegisterSampleTaken);
                        await _context.SaveChangesAsync();
                    }

                    var newClassClassification = reportRegister.caseClassification.Select(cc => new ReportRegisterCaseClassification
                    {
                        ReportRegisterId = ResportRegisterID,
                        SyndromeTypeId = cc.CCSyndromeTypeId == 0 ? null : cc.CCSyndromeTypeId,
                        CaseClassificationTypeId = cc.CaseClassificationTypeId,
                        DiseaseInfectionId = diseaseInfectionIds.TryGetValue(cc.DiseaseInfectionId.Trim(), out var infectionId) ? infectionId : 0, // Prevents FK violation
                        Active = true,
                        InsertedDate = DateTime.Now,
                        InsertedFrom = _conf["Jwt:UserID"].ToString()
                    }).ToList();

                    _context.ReportRegisterCaseClassification.AddRange(newClassClassification);
                    await _context.SaveChangesAsync();


                    _context.ReportRegisterStatus.Add(new ReportRegisterStatus
                    {
                        ReportRegisterId = ResportRegisterID,
                        ReportRegisterStatusTypeId = 6,
                        MedicalStaffId = medicalStaffID == 0 ? null : medicalStaffID,
                        Active = false,
                        InsertedDate = DateTime.Now,
                        InsertedFrom = _conf["Jwt:UserID"].ToString()
                    });
                    await _context.SaveChangesAsync();

                    if (reportRegister?.reportRegisterStatus == null || !reportRegister.reportRegisterStatus.Any())
                    {
                        transaction.Rollback();
                        _logService.InsertLog(currentHttpContext, "PostReportRegister", "reportRegisterStatus është i detyrueshëm" + json, true);
                        return BadRequest(new { Message = "reportRegisterStatus është i detyrueshëm." });
                    }

                    var newReportRegisterStatus = new List<ReportRegisterStatus>();

                var distinctStatuses = reportRegister.reportRegisterStatus
       .GroupBy(s => new
       {
           s.ReportRegisterStatusTypeId,
           s.HealthInstitutionIdentificationNumberTO,
           s.HealthInstitutionNameTo,
           s.HealthInstitutionAddressTo
       })
       .Select(g => g.First())
       .ToList();

                foreach (var status in distinctStatuses)
                {
                        if (status.ReportRegisterStatusTypeId == 6)
                        {
                            transaction.Rollback();
                            _logService.InsertLog(currentHttpContext, "PostReportRegister", "Nuk duhet te dergohet statusi 6" + json, true);
                            return BadRequest(new { Message = "Nuk duhet te dergohet statusi 6" });
                        }
                        if (status.ReportRegisterStatusTypeId == 0)
                        {
                            transaction.Rollback();
                            _logService.InsertLog(currentHttpContext, "PostReportRegister", "Nuk duhet te dergohet statusi 0" + json, true);
                            return BadRequest(new { Message = "Nuk duhet te dergohet statusi 0" });
                        }

                        var reportRegisterStatusItem = new ReportRegisterStatus
                        {
                            ReportRegisterId = ResportRegisterID,
                            ReportRegisterStatusTypeId = status.ReportRegisterStatusTypeId,
                            MedicalStaffId = medicalStaffID == 0 ? null : medicalStaffID,
                            Active = true,
                            InsertedDate = DateTime.Now,
                            InsertedFrom = _conf["Jwt:UserID"].ToString()
                        };

                        _context.ReportRegisterStatus.Add(reportRegisterStatusItem);
                        await _context.SaveChangesAsync(); // Ensure changes are saved before proceeding

                        var generatedReportRegisterStatusId = reportRegisterStatusItem.ReportRegisterStatusId;

                        if (status.ReportRegisterStatusTypeId == 2)
                        {
                            int healthInstitutionIDto = 0;
                            if (int.TryParse(status.HealthInstitutionIdentificationNumberTO, out int institutionIdd))
                            {
                                healthInstitutionIDto = await _context.HealthInstitution
                                    .Where(ms => ms.Bhisid == institutionIdd)
                                    .Select(ms => ms.HealthInstitutionId)
                                    .FirstOrDefaultAsync();
                            }

                            var reportRegisterReference = new ReportRegisterReference
                            {
                                ReportRegisterStatusId = generatedReportRegisterStatusId,
                                InsertedDate = DateTime.Now,
                                InsertedFrom = _conf["Jwt:UserID"].ToString(),
                                Active = true,
                                HealthInstitutionFromId = healthInstitutionID,
                                HealthInstitutionFromName = reportRegister.HealthInstitutionName,
                                HealthInstitutionFromAddress = reportRegister.HealthInstitutionAddress,
                                HealthInstitutionToId = healthInstitutionIDto,
                                HealthInstitutionToAddress = status.HealthInstitutionAddressTo,
                                HealthInstitutionToName = status.HealthInstitutionNameTo
                            };

                            _context.ReportRegisterReference.Add(reportRegisterReference);
                        }

                        newReportRegisterStatus.Add(reportRegisterStatusItem);
                    }


                    // ✅ Validate if any CaseClassificationTypeId is invalid
                    if (reportRegister.reportRegisterTest != null &&
            reportRegister.reportRegisterTest.Any(cc => cc.ExaminationId == 0))
                    {
                        transaction.Rollback();
                        _logService.InsertLog(currentHttpContext, "PostReportRegister", "ExaminationId është i pavlefshëm" + json, true);
                        return BadRequest(new { Message = "ExaminationId është i pavlefshëm." });
                    }
                    var newReportRegisterExamination = reportRegister.reportRegisterTest?
                        .Select(test => new ReportRegisterTest
                        {
                            ReportRegisterId = ResportRegisterID,
                            ExaminationId = test.ExaminationId,
                            TestTypeName = test.TestTypeName,
                            InsertedDate = DateTime.Now,
                            InsertedFrom = _conf["Jwt:UserID"].ToString()
                        }).ToList() ?? new List<ReportRegisterTest>();

                    if (newReportRegisterExamination.Any())
                    {
                        _context.ReportRegisterTest.AddRange(newReportRegisterExamination);
                        await _context.SaveChangesAsync();
                    }

                    _context.ReportRegisterTrackingStatus.Add(new ReportRegisterTrackingStatus
                    {
                        ReportRegisterId = ResportRegisterID,
                        StatusTypeId = 7,
                        Active = true,
                        InsertedDate = DateTime.Now,
                        InsertedFrom = _conf["Jwt:UserID"].ToString()
                    });
                    await _context.SaveChangesAsync();





                    transaction.Commit();
                    _logService.InsertLog(currentHttpContext, "PostReportRegister", "PostReportRegister inserted: " + json + "", false);
                    return Ok(new { UniqueNumber = uniqueNumber, Message = "Success" });
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    _logService.InsertLog(currentHttpContext, "PostReportRegister", "An error occurred while processing the request ReportRegister :" + ex.InnerException.ToString() + " " + json, true);
                    return BadRequest(new { Message = ex.InnerException.ToString() });
                }
            
        }

        public static int Age(DateTime birthdate, DateTime today)
        {
            int years = today.Year - birthdate.Year;
            if (today.Month < birthdate.Month || (today.Month == birthdate.Month && today.Day < birthdate.Day))
                years--;
            return years;
        }

        [HttpPost("PostReportRegisterTestResult")]
        public async Task<ActionResult<ReportRegisterTestResultVM>> PostReportRegisterTestResult(ReportRegisterTestResultVM reportRegisterTestResult)
        {
            var transaction = _context.Database.BeginTransaction();
            var currentHttpContext = _httpContextAccessor.HttpContext;
            string json = JsonConvert.SerializeObject(reportRegisterTestResult);
            //int healthInstitutionID = 0;

            //if (int.TryParse(reportRegisterTestResult.HealthInstitutionIdentificationNumber, out int institutionId))
            //{
            //    healthInstitutionID = await _context.HealthInstitution
            //       .Where(ms => ms.Bhisid == institutionId)
            //       .Select(ms => ms.HealthInstitutionId)
            //       .FirstOrDefaultAsync();
            //}
            //else
            //{
            //    // Handle parsing failure, possibly logging or throwing a more specific exception
            //}
            //if (healthInstitutionID == null || healthInstitutionID == 0)
            //{

            //    return Ok(new { Message = "Nuk u gjet asnje institucion shendetesor me keto parametra" });
            //}

            try 
            {
                _context.ReportRegisterTestResult.Add(new ReportRegisterTestResult
                {
                    ReportRegisterTestId = reportRegisterTestResult.ReportRegisterTestId,
                    HealthInstitutionId = 0,
                    HealthInstitutionCode = reportRegisterTestResult.HealthInstitutionCode,
                    HealthInstitutionName = reportRegisterTestResult.HealthInstitutionName,
                    HealthInstitutionAddress = reportRegisterTestResult.HealthInstitutionAddress,
                    IsPositive = reportRegisterTestResult.IsPositive,
                    ResultSchema = reportRegisterTestResult.ResultSchema,
                    TestCode = reportRegisterTestResult.TestCode,
                    ResultDate = reportRegisterTestResult.ResultDate,
                    UserName = reportRegisterTestResult.Username,
                    InsertedDate = DateTime.Now,
                    Active = true
                   

                }
                );
               
                await _context.SaveChangesAsync();  

                 

                transaction.Commit();
                _logService.InsertLog(currentHttpContext, "PostReportRegisterTestResult", "PostReportRegisterTestResult inserted: " + json + "", false);
                return Ok(new { Message = "Success" });
            }
            catch (Exception ex)
            {

                transaction.Rollback();
                _logService.InsertLog(currentHttpContext, "PostReportRegisterTestResult", "An error occurred while processing the request ReportRegisterTestResult :" + ex.InnerException.ToString() + " " + json, true);
                return BadRequest(new { Message = ex.InnerException.ToString() });
            }


        }


        //POST: api/PostDiseaseInfection
        //To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        
        [HttpPost("PostDiseaseInfection")]
        public async Task<ActionResult<DiseaseInfectionVM>> PostDiseaseInfection(DiseaseInfectionVM disease)
        {

            var currentHttpContext = _httpContextAccessor.HttpContext;
            var transaction = _context.Database.BeginTransaction();
            string jsonDisease = JsonConvert.SerializeObject(disease);
            try
            {

                var existingDisease = await _context.DiseaseInfection
                  .FirstOrDefaultAsync(ms => ms.DiseaseCode == disease.DiseaseCode);

                if (existingDisease == null)
                {
                    // Create new DiseaseInfection
                    _context.DiseaseInfection.Add(new DiseaseInfection
                    {
                        DiseaseInfectionTypeId = disease.DiseaseInfectionTypeId,
                        DiseaseCode = disease.DiseaseCode,
                        DataEncrypted = disease.DataEncrypted,
                        IsTransmissionDisease = disease.IsTransmissionDisease,
                        NameSq = disease.NameSq,
                        NameEn = disease.NameEn,
                        NameSr = disease.NameSr,
                        ReportingTimeTypeId = disease.ReportingTimeTypeId,
                        Description = disease.Description,
                        Active = disease.Active,
                        InsertedDate = DateTime.Now,
                        InsertedFrom = _conf["Jwt:UserID"].ToString()
                    }


                    );

                    await _context.SaveChangesAsync();
                     jsonDisease = JsonConvert.SerializeObject(disease);
                    transaction.Commit();
                    _logService.InsertLog(currentHttpContext, "PostDiseaseInfection", "DiseaseInfection created: " + jsonDisease + "", false);
                }
                else
                {
                    // Update DiseaseInfection

                    existingDisease.DiseaseInfectionTypeId = disease.DiseaseInfectionTypeId;
                    existingDisease.DataEncrypted = disease.DataEncrypted;
                    existingDisease.IsTransmissionDisease = disease.IsTransmissionDisease;
                    existingDisease.NameSq = disease.NameSq;
                    existingDisease.NameEn = disease.NameEn;
                    existingDisease.NameSr = disease.NameSr;
                    existingDisease.ReportingTimeTypeId = disease.ReportingTimeTypeId;
                    existingDisease.Description = disease.Description;
                    existingDisease.Active = disease.Active;
                    existingDisease.UpdatedDate = DateTime.Now;
                    existingDisease.UpdatedFrom = _conf["Jwt:UserID"];

                    await _context.SaveChangesAsync();
                   
                    transaction.Commit();
                    _logService.InsertLog(currentHttpContext, "PostDiseaseInfection", "DiseaseInfection updated: " + jsonDisease + "", false);
                }



                return Ok(new { Message = "Success" });
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                _logService.InsertLog(currentHttpContext, "PostDiseaseInfection", "An error occurred while processing the request Examination :" + ex.InnerException.ToString() + " " + jsonDisease, true);
                return BadRequest(new { Message = ex.InnerException.ToString() });
            }
        }





        //eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJTdGFuZGFyZCBVc2VyIiwibmJmIjoxNjk1MTMzNjM0LCJleHAiOjE4NTI5ODY0MzQsImlzcyI6IkVXU0FwaSIsImF1ZCI6IkVXU0FwaSJ9.lwx7O1E7ejZdNdOAvdLvL185TrAl7ZoL_6ALC9cZ84cSOq4xVpuvMpvtIvqXhJxwRIYxGt_LiKnJUSDtrv8pgA




        //[AllowAnonymous]
        //[HttpGet("Token")]
        //public string GenerateToken()
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_conf["Jwt:Key"]));
        //    var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

        //    List<Claim> claims = new List<Claim> {
        //     new Claim(ClaimTypes.Role, "Standard User")
        //};

        //    var token = new JwtSecurityToken(_conf["Jwt:Issuer"], _conf["Jwt:Audience"], claims: claims, notBefore: DateTime.Now, expires: DateTime.Now.AddYears(5), signingCredentials: credential);
        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}

    }
}
