using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EWSApi.Models;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace EWSAPI.Controllers;

[Authorize]
public class LogService : ControllerBase
{
    private IConfiguration _conf;
    private readonly EwsContext _context;
    public LogService(EwsContext context, IConfiguration conf)
    {
        this._context = context;
        _conf = conf;
    }


    public async Task InsertLog(HttpContext httpContext,string Action,string FormContent,bool BError)
    {

   
        _context.Add(new Log
        {
            Action = Action,
            ActionDescription = Action,
            BError = BError,
            Controller = "SMSNApi",
            InsertedDate = DateTime.Now,
            UserId = null,
            Ip = httpContext.Connection.RemoteIpAddress.ToString(),
            Description = "SMSNApi",
            Developer = "DataProgNet",
            DescriptionTitle = "Thirrja e API",
            HttpMethod = httpContext.Request.Method,
            HostName = httpContext.Connection.RemoteIpAddress.ToString(), //Dns.GetHostEntry(context.HttpContext.Connection.RemoteIpAddress.ToString()).HostName;
            Url = httpContext.Request.GetDisplayUrl(),
            Status = StatusCodes.Status200OK,
            FormContent = FormContent

        }
       
        );
        await _context.SaveChangesAsync();

       
      
    }
}
        
    

