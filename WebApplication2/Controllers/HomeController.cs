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
        [HttpGet]
        public ActionResult Registration(int? Event_Id)
            {
                if(Event_Id != null)
                {
                    ViewBag.IdEvent = db.Set<Event>().Find(Event_Id);

                    return View();
                }
                else
                {
                    return null;
                }
                
            }
        [HttpPost]
        public string Registration(Registration registration)
            {
                registration.Date = DateTime.Now;
                db.Registrations.Add(registration);
                db.SaveChanges();
                return "Спасибо" + registration.Name + registration.SurName + ", за регистрацию!";
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