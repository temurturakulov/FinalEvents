using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication2.Models;
namespace Razor.Controllers { 
namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        EventContext db=new EventContext();

        public ActionResult Index()
        {
            var events = db.Events;
            ViewBag.Events = events;
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
}