using System;
using System.Web.Mvc;
using SerilogWeb.Classic.Extensions;

namespace SerilogWeb.Classic.Mvc
{
    internal class SerilogWebClassicExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled || filterContext.HttpContext.IsCustomErrorEnabled)
            {
                var exception = filterContext.Exception;
                if (exception != null)
                {
                    filterContext.HttpContext.AddSerilogWebError(exception);
                }
            }
        }
    }
}