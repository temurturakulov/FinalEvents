using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Registration
    {
        public int Registration_Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBors { get; set; }
        public string Country { get; set; }
    }
}