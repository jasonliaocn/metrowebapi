namespace metroservices.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<metroservices.Models.MetroservicesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(metroservices.Models.MetroservicesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Tags.Add(new Models.Tag { Comments = "this is for testing", CreateDate = DateTime.Now, UserId = 1, Lat = 31.546941, Lng = 120.331878 });
            //
        }
    }
}
