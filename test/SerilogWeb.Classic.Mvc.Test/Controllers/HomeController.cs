using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerilogWeb.Classic.Mvc.Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Custom/{stringParam}/details/{intParam}")]
        public ActionResult Custom(string stringParam, int intParam)
        {
            ViewBag.Message = $"CustomPage({stringParam}, {intParam})";

            return View();
        }
    }
}