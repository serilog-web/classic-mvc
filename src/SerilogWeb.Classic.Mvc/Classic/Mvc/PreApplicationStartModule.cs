using System.Web.Mvc;

namespace SerilogWeb.Classic.Mvc
{
    public class PreApplicationStartModule
    {
        public static void Register()
        {
            GlobalFilters.Filters.Add(new StoreMvcInfoInHttpContextActionFilter());
            GlobalFilters.Filters.Add(new SerilogWebClassicExceptionFilter());
        }
    }
}
