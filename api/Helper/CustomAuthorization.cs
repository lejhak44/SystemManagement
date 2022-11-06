using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace ngJSApp.Controllers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class CustomAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly string _someFilterParameter;

        public CustomAuthorizeAttribute() { }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //var user = context.HttpContext.User;
            //var config = context.HttpContext.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;
            //var IsDevMode = config.GetValue<bool>("DevMode");
            //if (IsDevMode == true) return;
            //if (!user.Identity.IsAuthenticated)
            //{
            //    // it isn't needed to set unauthorized result 
            //    // as the base class already requires the user to be authenticated
            //    // this also makes redirect to a login page work properly
            //    // context.Result = new UnauthorizedResult();
            //    return;
            //};
            //var isAuthorized = someService.IsUserAuthorized(user.Identity.Name, _someFilterParameter);
            //if (!isAuthorized)
            //{
            //    context.Result = new StatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);
            //    return;
            //}
        }
    }
}