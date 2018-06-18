namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.EventContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
           // AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WebApplication2.Models.EventContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
