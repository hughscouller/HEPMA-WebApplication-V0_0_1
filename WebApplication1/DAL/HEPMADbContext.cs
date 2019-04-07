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

    }
}