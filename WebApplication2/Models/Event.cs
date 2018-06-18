using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Event
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [Key]
        public int Event_Id { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        // Ссылка на регистрацию
        [ForeignKey("Event_Id")]
        public List<Registration> Registrations { get; set; }
    }
}