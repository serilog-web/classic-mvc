using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Json;
using SerilogWeb.Classic.Mvc.Enrichers;

namespace SerilogWeb.Classic.Mvc.Test
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Serilog.Log.Logger = new LoggerConfiguration()
                .Enrich.With<MvcControllerNameEnricher>()
                .Enrich.With<MvcRouteDataEnricher>()
                .Enrich.With<MvcRouteTemplateEnricher>()
                .Enrich.With<MvcActionNameEnricher>()
                .WriteTo.Trace(new JsonFormatter())
                .CreateLogger();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Serilog.Log.CloseAndFlush();
        }
    }
}
