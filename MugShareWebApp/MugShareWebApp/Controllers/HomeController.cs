using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MugShareWebApp.Controllers
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

        public ActionResult Machines()
        {
            ViewBag.Message = "Your machine information page.";
            return View();
        }

        public ActionResult ManageUsers()
        {
            ViewBag.Message = "Your managing mug share users page.";
            return View();
        }

        public ActionResult Security()
        {
            ViewBag.Message = "Your managing staff and admin users page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}