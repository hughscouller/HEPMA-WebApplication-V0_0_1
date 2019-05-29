namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models.HEPMA;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.DAL.HEPMADbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.DAL.HEPMADbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.HospitalSites.AddOrUpdate(x => x.Id,
            //    new HospitalSite() { Id = 1, Name = "Edinburgh Royal Hospital" },
            //    new HospitalSite() { Id = 2, Name = "Western General Hospital" },
            //    new HospitalSite() { Id = 3, Name = "St John's Hospital" },
            //    new HospitalSite() { Id = 4, Name = "Royal Infirmary Edinburgh" },
            //    new HospitalSite() { Id = 5, Name = "Princess Alexandra Eye Pavilion" }
            //    );
        }
    }
}

