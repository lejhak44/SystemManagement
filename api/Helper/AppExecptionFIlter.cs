﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ngJSApp
{
    public class AppExecptionFIlter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;
            String message = context.Exception.Message;

            //var exceptionType = context.Exception.GetType();
            //if (exceptionType == typeof(UnauthorizedAccessException))
            //{
            //    message = "Unauthorized Access";
            //    status = HttpStatusCode.Unauthorized;
            //}
            //else if (exceptionType == typeof(NotImplementedException))
            //{
            //    message = "A server error occurred.";
            //    status = HttpStatusCode.NotImplemented;
            //}
            ////else if (exceptionType == typeof(MyAppException))
            ////{
            ////    message = context.Exception.ToString();
            ////    status = HttpStatusCode.InternalServerError;
            ////}
            //else
            //{
            //    message = context.Exception.Message;
            //    status = HttpStatusCode.NotFound;
            //}
            context.ExceptionHandled = true;
            HttpResponse response = context.HttpContext.Response;
            response.StatusCode = (int)status;
            response.ContentType = "application/json";
            var err = message + " " + context.Exception.StackTrace;
            response.WriteAsync(err);
        }
    }
}
