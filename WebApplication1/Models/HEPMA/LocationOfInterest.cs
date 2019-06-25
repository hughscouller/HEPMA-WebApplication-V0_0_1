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
        public int LoIId { get; set; }
        public string LoIName { get; set; }
        public string LoIRoomReference { get; set; }
        public string LoIDescription { get; set; }
        public bool LoIPrescribing { get; set; }
        public bool LoIMedicinesAdministration { get; set; }
        public bool LoIPharmacyCheck { get; set; }
        public string LoINotes { get; set; }
        public int LoIAoCId { get; set; }

        public virtual AreaOfCare AreaOfCare { get; set; }
    }
}