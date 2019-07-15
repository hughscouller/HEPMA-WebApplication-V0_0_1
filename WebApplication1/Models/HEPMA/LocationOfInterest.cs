using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class LocationOfInterest
    {
        [Key]
        [Display(Name = "LoC ID")]
        public int LoIId { get; set; }
        [Display(Name = "LoI Name")]
        public string LoIName { get; set; }
        [Display(Name = "Room Ref No")]
        public string LoIRoomReference { get; set; }
        [Display(Name = "Description")]
        public string LoIDescription { get; set; }
        [Display(Name = "Prescribing")]
        public bool LoIPrescribing { get; set; }
        [Display(Name = "Med Admin")]
        public bool LoIMedicinesAdministration { get; set; }
        [Display(Name = "Pharm Check")]
        public bool LoIPharmacyCheck { get; set; }
        [Display(Name = "Note")]
        public string LoINotes { get; set; }
        [Display(Name = "AoC ID")]
        public int LoIAoCId { get; set; }

        public virtual AreaOfCare AreaOfCare { get; set; }
    }
}