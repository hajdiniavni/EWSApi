using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EWSApi.Core;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Data.SqlClient;

namespace EWSAPI.Controllers;


public class LogService : ControllerBase
{
    private IConfiguration _conf;
    private readonly AppDBContext _context;
    public LogService(AppDBContext context, IConfiguration conf)
    {
        this._context = context;
        _conf = conf;
    }


    public void InsertLog(HttpContext httpContext, string Action, string FormContent, bool BError)
    {


        
        //if (BError == true)
        //{
        //    var ip = new SqlParameter("@IP", httpContext.Connection.RemoteIpAddress.ToString());
        //    var httpMethod = new SqlParameter("@HttpMethod", httpContext.Request.Method);
        //    var hostName = new SqlParameter("@HostName", httpContext.Connection.RemoteIpAddress.ToString());
        //    var url = new SqlParameter("@Url", httpContext.Request.GetDisplayUrl());
        //    var status = new SqlParameter("@Status", StatusCodes.Status200OK);
        //    var action = new SqlParameter("@Action", Action);
        //    var formContent = new SqlParameter("@FormContent", FormContent);
        //    var bError = new SqlParameter("@BError", BError);
        //    _context.Database.ExecuteSqlRaw("EXEC InsertDataLog @IP,@HttpMethod,@HostName,@Url,@Status,@Action, @FormContent,@BError", ip, httpMethod, hostName, url, status, action, formContent, bError);
        //}
        //else
        //{
        var transaction = _context.Database.BeginTransaction();

            try
            {
                _context.Log.Add(new Log
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


                _context.SaveChanges();
                transaction.Commit();
            }

            catch (Exception ex)
            {
                transaction.Rollback();

            }
        //}
    }



    
}
        
    

