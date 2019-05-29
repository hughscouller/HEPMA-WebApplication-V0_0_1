using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class HospitalSite
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Site name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Planned start")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? PlannedStart { get; set; }
        [Display(Name = "Planned complete")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? PlannedComplete { get; set; }

        [Display(Name = "Standard Bed")]
        public int AccommodationComplimentStandardBed { get; set; }
        [Display(Name = "Day surgery bed")]
        public int AccommodationComplimentDaySurgeryBed { get; set; }
        [Display(Name = "Trolly")]
        public int AccommodationComplimentTrolly { get; set; }
        [Display(Name = "Chair")]
        public int AccommodationComplimentChair { get; set; }
        [Display(Name = "Special care cot")]
        public int AccommodationComplimentSpecialCareBabyUnitCot { get; set; }


        public virtual ICollection<SiteLocation> SiteLocations { get; set; }

    }
}