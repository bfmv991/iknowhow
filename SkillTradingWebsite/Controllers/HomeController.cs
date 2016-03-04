using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTradingWebsite.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Seitenbeschreibung";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontaktseite";

            return View();
        }
    }
}