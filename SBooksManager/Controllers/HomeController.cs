using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBooksManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Books()
        {
            ViewBag.Message = "Your books page.";

            return View();
        }

        public ActionResult Promotions()
        {
            ViewBag.Message = "Your promotion page. Manage Promotions and coupons here.";

            return View();
        }

        public ActionResult Employees()
        {
            ViewBag.Message = "Your employee management page.";

            return View();
        }
        public ActionResult Customers()
        {
            ViewBag.Message = "Your customer management page.";

            return View();
        }
    }
}