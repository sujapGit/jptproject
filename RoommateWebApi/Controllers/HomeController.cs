using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoommateWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            // hi i am
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your apption page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You contact.";

            return View();
        }
    }
}