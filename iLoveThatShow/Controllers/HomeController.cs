using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iLoveThatShow.Controllers
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
        public ActionResult Enter()
        {
            ViewBag.Message = "Enter the Site";
            return View();
        }
        public ActionResult ToDo()
        {
            ViewBag.Message = "What do you want to do?";
            return View("ToDo");
        }
        public ActionResult Calendar()
        {
            ViewBag.Message = "See Viewing Parties or Add an Event";
            return View("Calendar");
        }
        public ActionResult Chat()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
    }//public class HomeController : Controller
}//namespace