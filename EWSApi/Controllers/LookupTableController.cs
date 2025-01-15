using EWSAPI.Controllers;
using EWSApi.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EWSApi.Controllers
{
    [Route("api"), Authorize]
    [ApiController]
    public class LookupTableController : Controller
    {
        private IConfiguration _conf;
        private readonly LogService _logService;
        private readonly EwsContext _context;
        private readonly AppDBContext _sqlContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LookupTableController(EwsContext context, AppDBContext sqlContext, LogService logService, IHttpContextAccessor httpContextAccessor, IConfiguration conf)
        {
            this._context = context;
            this._sqlContext = sqlContext;
            _conf = conf;
            this._logService = logService;
            this._httpContextAccessor = httpContextAccessor;
        }

        //eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJTdGFuZGFyZCBVc2VyIiwibmJmIjoxNzA4NDQxODE4LCJleHAiOjE4NjYyOTQ2MTgsImlzcyI6IlJCS0FQaSIsImF1ZCI6IlJCS0FQaSJ9.hR9wkyTo1jatilR23gH-gjQd2Q8OF72zkl9nIiz4vCpHXH-JgS0JW5SUbQd454JewDcfMpne0-fTMFUtGqs5xA
        //[AllowAnonymous]
        //[HttpGet("Token")]
        //public string GenerateToken()
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("RBK2024#ApiSecretKey"));
        //    var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

        //    List<Claim> claims = new List<Claim> {
        //     new Claim(ClaimTypes.Role, "Standard User")
        //};

        //    var token = new JwtSecurityToken("RBKAPi", "RBKAPi", claims: claims, notBefore: DateTime.Now, expires: DateTime.Now.AddYears(5), signingCredentials: credential);
        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}




        [HttpGet("CaseClassificationType")]
        public async Task<ActionResult<IEnumerable<object>>> CaseClassificationType(int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.CaseClassificationType
                                select new
                                {
                                    ID = p.CaseClassificationTypeId,
                                    CaseClassificationType = LanguageID == 1 ? p.NameSq : LanguageID == 2 ? p.NameEn : LanguageID == 3 ? p.NameSr : p.NameSr
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "CaseClassificationType", "LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "CaseClassificationType", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }


        [HttpGet("DiseaseInfectionType")]
        public async Task<ActionResult<IEnumerable<object>>> DiseaseInfectionType(int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.DiseaseClassificationType
                                select new
                                {
                                    ID = p.DiseaseClassificationTypeId,
                                    DiseaseClassificationType = LanguageID == 1 ? p.NameSq : LanguageID == 2 ? p.NameEn : LanguageID == 3 ? p.NameSr : p.NameSq
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "DiseaseInfectionType", "LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "DiseaseInfectionType", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }

        [HttpGet("DiseaseInfection")]
        public async Task<ActionResult<IEnumerable<object>>> DiseaseInfection(int DiseaseInfectionTypeID, int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.DiseaseInfection
                                where p.DiseaseInfectionTypeId == DiseaseInfectionTypeID
                                select new
                                {
                                    ID = p.DiseaseInfectionId,
                                    DiseaseInfection = LanguageID == 1 ? p.NameSq : LanguageID == 2 ? p.NameEn : LanguageID == 3 ? p.NameSr : p.NameSq
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "DiseaseInfection", "LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "DiseaseInfection", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }


        [HttpGet("Examination")]
        public async Task<ActionResult<IEnumerable<object>>> Examination()
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.Examination
                                select new
                                {
                                    ID = p.ExaminationId,
                                    ExaminationName = p.ExaminationName
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "Examination", "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "Examination", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }

        [HttpGet("ReportRegisterStatusType")]
        public async Task<ActionResult<IEnumerable<object>>> ReportRegisterStatusType(int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.ReportRegisterStatusType
                                select new
                                {
                                    ID = p.ReportRegisterStatusTypeId,
                                    ReportRegisterStatusType = LanguageID == 1 ? p.NameSq : LanguageID == 2 ? p.NameEn : LanguageID == 3 ? p.NameSr : p.NameSq
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "ReportRegisterStatusType", "LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "ReportRegisterStatusType", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }

        [HttpGet("SampleTakenType")]
        public async Task<ActionResult<IEnumerable<object>>> SampleTakenType(int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.SampleTakenType
                                select new
                                {
                                    ID = p.SampleTakenTypeId,
                                    SampleTakenType = LanguageID == 1 ? p.SampleTakenTypeSq : LanguageID == 2 ? p.SampleTakenTypeEn : LanguageID == 3 ? p.SampleTakenTypeSr : p.SampleTakenTypeSq
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "SampleTakenType", "LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "SampleTakenType", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }


        [HttpGet("Country")]
        public async Task<ActionResult<IEnumerable<object>>> Country(int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.Country
                                select new
                                {
                                    ID = p.CountryId,
                                    Country = LanguageID == 1 ? p.NameSq : LanguageID == 2 ? p.NameEn : LanguageID == 3 ? p.NameSr : p.NameSq
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "Country", "LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "Country", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }

        [HttpGet("City")]
        public async Task<ActionResult<IEnumerable<object>>> City(int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.City
                                select new
                                {
                                    ID = p.CityId,
                                    City = LanguageID == 1 ? p.NameSq : LanguageID == 2 ? p.NameEn : LanguageID == 3 ? p.NameSr : p.NameSq
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "City", "LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "City", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }

        [HttpGet("Settlement")]
        public async Task<ActionResult<IEnumerable<object>>> Settlement(int CityID, int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.Settlement
                                where p.CityId == CityID
                                select new
                                {
                                    ID = p.SettlementId,
                                    Settlement = LanguageID == 1 ? p.NameSq : LanguageID == 2 ? p.NameEn : LanguageID == 3 ? p.NameSr : p.NameSq
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "Settlement", "CityID= " + CityID + ", LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "Settlement", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }

        [HttpGet("SuspectedPlaceType")]
        public async Task<ActionResult<IEnumerable<object>>> SuspectedPlaceType(int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.SuspectedPlaceType
                                select new
                                {
                                    ID = p.SuspectedPlaceTypeId,
                                    SuspectedPlaceType = LanguageID == 1 ? p.NameSq : LanguageID == 2 ? p.NameEn : LanguageID == 3 ? p.NameSr : p.NameSq
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "SuspectedPlaceType", "LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "SuspectedPlaceType", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }

        [HttpGet("SyndromeType")]
        public async Task<ActionResult<IEnumerable<object>>> SyndromeType(int LanguageID)
        {
            var currentHttpContext = _httpContextAccessor.HttpContext;





            var result = await (from p in _context.SyndromeType
                                select new
                                {
                                    ID = p.SyndromeTypeId,
                                    SyndromeType = LanguageID == 1 ? p.NameSq : LanguageID == 2 ? p.NameEn : LanguageID == 3 ? p.NameSr : p.NameSq
                                }).ToListAsync();




            _logService.InsertLog(currentHttpContext, "SyndromeType", "LanguageID= " + LanguageID + "", false);




            if (result == null || result.Count == 0)
            {
                _logService.InsertLog(currentHttpContext, "SyndromeType", "An error occurred while processing the request", true);
                return NotFound();

            }

            return Ok(result);
        }

    }
}
