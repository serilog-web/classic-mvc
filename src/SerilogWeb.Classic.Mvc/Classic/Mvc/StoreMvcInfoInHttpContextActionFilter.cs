using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SerilogWeb.Classic.Mvc
{
    internal class StoreMvcInfoInHttpContextActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            StoreMvcInfoInHttpContext(filterContext);
            base.OnActionExecuting(filterContext);
        }

        private static void StoreMvcInfoInHttpContext(ActionExecutingContext actionContext)
        {
            var currentHttpContext = HttpContext.Current;
            if (currentHttpContext == null)
                return;

            var actionDescriptor = actionContext.ActionDescriptor;
            var routeData = actionContext.RequestContext.RouteData;

            var actionName = actionDescriptor.ActionName;
            var controllerName = actionDescriptor.ControllerDescriptor.ControllerName;


            var route = routeData.Route as Route;
            string routeTemplate = null;
            if (route != null)
            {
                routeTemplate = route.Url;
            }
            var routeDataDictionary = new Dictionary<string, object>(routeData.Values);

            var contextualInfo =
                new Dictionary<MvcRequestInfoKey, object>
                {
                    [MvcRequestInfoKey.RouteUrlTemplate] = routeTemplate,
                    [MvcRequestInfoKey.RouteData] = routeDataDictionary,
                    [MvcRequestInfoKey.ActionName] = actionName,
                    [MvcRequestInfoKey.ControllerName] = controllerName
                };

            currentHttpContext.Items[Constants.MvcContextInfoKey] = contextualInfo;
        }
    }
}