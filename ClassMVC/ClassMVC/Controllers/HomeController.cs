using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using ClassMVC.Models;

namespace ClassMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person person = new Person { FirstName = "Paul", LastName = "Colon"};
            return View(person);
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