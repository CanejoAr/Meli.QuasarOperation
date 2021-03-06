﻿using Microsoft.AspNetCore.Mvc.Filters;
using QuasarOperation.Domain.Exceptions;

namespace QuasarOperation.WebAPI.Filters
{
    public class HttpResponseActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is CantRecoverMessageException exception)
            {
                context.HttpContext.Response.StatusCode = exception.Status;
                context.ExceptionHandled = true;
            }

            if (context.Exception is CantDeterminateLocationException locationException)
            {
                context.HttpContext.Response.StatusCode = locationException.Satatus;
                context.ExceptionHandled = true;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context) { }
    }
}
