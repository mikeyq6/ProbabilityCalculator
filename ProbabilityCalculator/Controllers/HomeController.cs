using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProbabilityCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Probability Calculator";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View();
        }
    }
}
