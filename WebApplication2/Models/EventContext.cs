using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Registration> Registrations { get; set; }

    }

    public class EventDbInitializer : DropCreateDatabaseAlways<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            context.Events.Add(new Event { EventName = "Новый год", StartDate = DateTime.Parse("12.05.1995"), EndDate = DateTime.Parse("16.05.1995") });
            context.Events.Add(new Event { EventName = "Хаит", StartDate = DateTime.Parse("15.06.2018"), EndDate = DateTime.Parse("17.06.2018") });
            base.Seed(context);
        }
    }
}