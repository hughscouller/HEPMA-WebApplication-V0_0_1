using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models.HEPMA;

namespace WebApplication1.DAL
{
    public class HEPMADbContext : DbContext
    {
        public DbSet<HospitalSite> HospitalSites { get; set; }
        public DbSet<SiteLocation> SiteLocations { get; set; }
        public DbSet<AreaOfCare> AreasOfCare { get; set; }

        public DbSet<NotesFieldHospitalSite> HospitalNotes { get; set; }

        public DbSet<NotesFieldSiteLocation> LocationNotes { get; set; }

        public DbSet<LocationOfInterest> LocationOfInterest { get; set; }

        //public System.Data.Entity.DbSet<WebApplication1.Models.HEPMA.LocationOfInterest> LocationOfInterests { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.HEPMA.Hardware> Hardwares { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.HEPMA.NotesFieldAreaOfCare> NotesFieldAreaOfCares { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.HEPMA.NotesFieldLocationOfInterest> NotesFieldLocationOfInterest { get; set; }
    }
}