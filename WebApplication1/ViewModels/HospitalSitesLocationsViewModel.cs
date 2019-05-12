using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.HEPMA;

namespace WebApplication1.ViewModels
{
    public class HospitalSitesLocationsViewModel
    {
        public SelectList SL { get; set; }


        public IEnumerable<HospitalSite> HospitalSites { get; set; } 
        public SiteLocation SiteLocation { get; set; }
    }
}