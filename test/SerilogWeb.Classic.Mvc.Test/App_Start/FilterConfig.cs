using System.Web;
using System.Web.Mvc;

namespace SerilogWeb.Classic.Mvc.Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
