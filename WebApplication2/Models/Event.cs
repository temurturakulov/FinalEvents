using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Event
    {
        public int Event_Id { get; set; }
        public string EventName { get; set; }
        public string NumberOfPeople { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}