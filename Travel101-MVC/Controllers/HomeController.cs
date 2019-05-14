using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel101_MVC.Data;

namespace Travel101_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TravelContext _context = new TravelContext();
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
    }
}