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
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Descrption { get; set; }
        [Display(Name = "Note")]
        public string Notes { get; set; }
        [Display(Name = "Hosp Site ID")]
        public int? HospitalSiteId { get; set; }

        public virtual HospitalSite HospitalSite { get; set; }

        public virtual ICollection<AreaOfCare> AreaOfCare { get; set; }

    }
}