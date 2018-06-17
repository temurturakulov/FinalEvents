using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Registration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // only if your primary key is auto-generated/identity column
        [Key]
        public int Registration_Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBors { get; set; }
        public string Country { get; set; }
        public DateTime Date { get; internal set; }
    }
}