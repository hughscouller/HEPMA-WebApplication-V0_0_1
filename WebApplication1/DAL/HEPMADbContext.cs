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

        public DbSet<Hardware> Hardwares { get; set; }

        public DbSet<NotesFieldAreaOfCare> NotesFieldAreaOfCares { get; set; }

        public DbSet<NotesFieldLocationOfInterest> NotesFieldLocationOfInterest { get; set; }
    }
}