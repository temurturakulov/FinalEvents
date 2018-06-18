using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication2.Models;
namespace Razor.Controllers
{
    namespace WebApplication2.Controllers
    {
        public class HomeController : Controller
        {
            EventContext db = new EventContext();

            public ActionResult Index()
            {
                var events = db.Events;
                ViewBag.Events = events;
                return View();
            }
            [HttpGet]
            public ActionResult Registration(int Event_Id)
            {


                ViewBag.IdEvent = db.Events.Find(Event_Id);

                return View();
            }

            [HttpGet]
            public ActionResult Users()
            {
                ViewBag.Registration = db.Registrations;
                return View();
            }
            


            [HttpPost]
            public ActionResult Registration(Registration registration)
            {
                try
                {
                    registration.Date = DateTime.Now;
                    /*Registration reg = new Registration()
                    {
                        Name = registration.Name,
                        SurName = registration.SurName,
                        Country = registration.Country,
                        Date = registration.Date,
                        DateBors = registration.DateBors,
                        Event_Id = registration.Event_Id,
                        LastName = registration.LastName
                    };*/
                    db.Registrations.Add(registration);

                    db.SaveChanges();
                    ViewBag.Reg_Id = registration.Registration_Id;
                    ViewBag.Message = "Спасибо " + registration.Name + " " + registration.SurName + " , за регистрацию!";
                    return View();
                }
                catch (SqlException ex)
                {
                    return null;
                }


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


            public string GetRegistered(int id)
            {
                return db.Registrations.Find(id).ToString();
            }
        }
    }
}