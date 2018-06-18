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
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateBors { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public DateTime Date { get;  set; }

        //Ссылка на мероприятия
        public int Event_Id { get; set; }
        
        public Event Event { get; set; }

    }
}