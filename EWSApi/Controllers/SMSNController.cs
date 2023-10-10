using EWSAPI.Controllers;
using EWSApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Newtonsoft.Json;

namespace EWSApi.Controllers
{
    [Route("api/[controller]"), Authorize]
    [ApiController]
    public class SMSNController : Controller
    {
        private IConfiguration _conf;
        private readonly LogService _logService;
        private readonly EwsContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SMSNController(EwsContext context, LogService logService, IHttpContextAccessor httpContextAccessor, IConfiguration conf)
        {
            this._context = context;
            _conf = conf;
            this._logService = logService;
            this._httpContextAccessor = httpContextAccessor;
        }


        // GET: api/SMSN/GetLabData/578
        [HttpGet("GetLabData/{UniqueNumber}/{LabCode}")]
        public async Task<ActionResult<SMSNController>> GetLabData(string UniqueNumber, string LabCode)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;


            if (_context.ReportRegister == null)
            {
                await _logService.InsertLog(currentHttpContext, "GetLabData", "Nuk u gjet asnje me keto UniqueNumber= " + UniqueNumber + ", Laboratory code= " + LabCode + ", Accepted date= " + DateTime.Now.ToString() + "", true);
                return NotFound();
            }




            var result = await (from rr in _context.ReportRegister
                                join cr in _context.CitizenRegister on rr.CitizenRegisterId equals cr.CitizenRegisterId
                                join c in _context.Country on cr.CountryId equals c.CountryId
                                join rrs in _context.ReportRegisterStatus
                                     on new { rr.ReportRegisterId, Active = true } equals new { rrs.ReportRegisterId, rrs.Active }
                                join ms in _context.MedicalStaff on rrs.MedicalStaffId equals ms.MedicalStaffId
                                join rrt in _context.ReportRegisterTest on rr.ReportRegisterId equals rrt.ReportRegisterId
                                join e in _context.Examination on rrt.ExaminationId equals e.ExaminationId into testTypes
                                where (rr.UniqueNumber == UniqueNumber) || (cr.PersonalNumber == UniqueNumber) // Assuming personalNumberParameter is the parameter for @PersonalNumber
                                select new
                                {
                                    UniqueNumberSMSN = rr.UniqueNumber,
                                    PersonalNumber = cr.PersonalNumber,
                                    Name = cr.Firstname,
                                    ParentName = cr.FatherName,
                                    Surname = cr.Lastname,
                                    Address = $"{c.NameSq}, {cr.Municipality}, {cr.Address}",
                                    Doctor = $"{ms.Firstname} {ms.Lastname} - {ms.LicenceNumber}",
                                    SampleTaken = rr.SampleTakenDate == null ? "NO" : "YES",
                                    SampleTakenDate = rr.SampleTakenDate,
                                    TestType = testTypes.Select(tt => new { TestNumber = tt.ExaminationCode, Description = tt.ExaminationName }).ToArray(),


                                }).ToListAsync();

            

            await _logService.InsertLog(currentHttpContext, "GetLabData", "UniqueNumber= " + UniqueNumber + ", Laboratory code= "+LabCode+ ", Accepted date= "+DateTime.Now.ToString()+"",false);




            if (result == null || result.Count == 0)
            {
                await _logService.InsertLog(currentHttpContext, "GetLabData", "Nuk u gjet asnje me keto UniqueNumber= " + UniqueNumber + ", Laboratory code= " + LabCode + ", Accepted date= " + DateTime.Now.ToString() + "", true);
                return NotFound();
               
            }

            return Ok(result);
        }



        // POST: api/PostMedicalStaff
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostMedicalStaff")]
        public async Task<ActionResult<MedicalStaff>> PostMedicalStaff(MedicalStaff medicalStaff)
        {

            var currentHttpContext = _httpContextAccessor.HttpContext;
            try
            {
                if (!ModelState.IsValid)
                {
                    await _logService.InsertLog(currentHttpContext, "PostMedicalStaff", "An error occurred while processing the request MedicalStaff", true);
                    return BadRequest(ModelState);

                }

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

                    string jsonMedicalStaff = JsonConvert.SerializeObject(medicalStaff);
                    await _logService.InsertLog(currentHttpContext, "PostMedicalStaff", "MedicalStaff created: " + jsonMedicalStaff + "", false);
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
                    string jsonMedicalStaff = JsonConvert.SerializeObject(existingMedicalStaff);
                    await _logService.InsertLog(currentHttpContext, "PostMedicalStaff", "MedicalStaff updated: " + jsonMedicalStaff + "", false);
                }



                return Ok(new { Message = "Success" });
            }
            catch
            {
                string jsonMedicalStaff = JsonConvert.SerializeObject(medicalStaff);
                await _logService.InsertLog(currentHttpContext, "PostMedicalStaff", "An error occurred while processing the request MedicalStaff :" + jsonMedicalStaff + "", true);
                return BadRequest(new { Message = "BadRequest" });
            }
        }


        //POST: api/PostExamination
        //To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostExamination")]
        public async Task<ActionResult<Examination>> PostExamination(Examination examination)
        {

            var currentHttpContext = _httpContextAccessor.HttpContext;
            try
            {
                if (!ModelState.IsValid)
                {
                    await _logService.InsertLog(currentHttpContext, "PostExamination", "An error occurred while processing the request Examination", true);
                    return BadRequest(ModelState);

                }

                var existingExamination = await _context.Examination
                  .FirstOrDefaultAsync(ms => ms.ExaminationId == examination.ExaminationId);

                if (existingExamination == null)
                {
                    // Create new medical staff
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

                    string jsonExamination = JsonConvert.SerializeObject(examination);
                    await _logService.InsertLog(currentHttpContext, "PostExamination", "Examination created: " + jsonExamination + "", false);
                }
                else
                {
                    // Update existing medical staff

                    existingExamination.ExaminationName=examination.ExaminationName;
                    existingExamination.ExaminationCode=examination.ExaminationCode;
                    existingExamination.IsEpidemic=examination.IsEpidemic;
                    existingExamination.ResultTime=examination.ResultTime;
                    existingExamination.LocalPrice=examination.LocalPrice;
                    existingExamination.ForeignPrice=examination.ForeignPrice;
                    existingExamination.Active=examination.Active;
                    existingExamination.IsDynamic=examination.IsDynamic;
                    existingExamination.UpdatedDate = DateTime.Now;
                    existingExamination.UpdatedFrom = _conf["Jwt:UserID"];

                    await _context.SaveChangesAsync();
                    string jsonExamination = JsonConvert.SerializeObject(examination);
                    await _logService.InsertLog(currentHttpContext, "PostExamination", "Examination updated: " + jsonExamination + "", false);
                }



                return Ok(new { Message = "Success" });
            }
            catch
            {
                string jsonExamination = JsonConvert.SerializeObject(examination);
                await _logService.InsertLog(currentHttpContext, "PostExamination", "An error occurred while processing the request Examination :" + jsonExamination + "", true);
                return BadRequest(new { Message = "BadRequest" });
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
