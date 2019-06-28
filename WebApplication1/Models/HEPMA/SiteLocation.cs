using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class SiteLocation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
        public string Notes { get; set; }
        public int? HospitalSiteId { get; set; }
        public virtual HospitalSite HospitalSite { get; set; }

        public virtual ICollection<AreaOfCare> AreaOfCare { get; set; }

    }
}