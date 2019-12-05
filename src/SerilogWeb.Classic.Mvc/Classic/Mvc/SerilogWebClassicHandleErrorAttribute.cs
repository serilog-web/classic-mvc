using System;
using System.Web.Mvc;
using SerilogWeb.Classic.Extensions;

namespace SerilogWeb.Classic.Mvc
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    internal class SerilogWebClassicHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);

            if (!filterContext.ExceptionHandled)
            {
                return;
            }

            var exception = filterContext.Exception;
            if (exception != null)
            {
                filterContext.HttpContext.AddSerilogWebError(exception);
            }
        }
    }
}