using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TSP.Controllers
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

        public ActionResult Academics()
        {
            ViewBag.Message = "Yahan padhai nai hoti.";
            return View();
        }

        public ActionResult Community()
        {
            ViewBag.Msg = "Log aate hi nai...:(";
            return View();
        }

        public ActionResult VisitSchool()
        {
            ViewBag.A = "Bache talented hai school jaane ki jarurat hi nai.";
            return View();
        }
    }
}