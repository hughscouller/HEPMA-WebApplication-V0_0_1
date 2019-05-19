using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class AreaOfCare
    {

        
        [Key]
        public int AoCId { get; set; }

        // EF Navigation items section /////////////////////////////////////////
        public virtual SiteLocation SiteLocation { get; set; }
        public int SiteLocationId { get; set; } 

        // General data section /////////////////////////////////////////
        [Display(Name = "Name")]
        public string AoCName { get; set; }
        [Display(Name = "Type")]
        public string AoCType { get; set; }
        [Display(Name = "Description")]
        public string AoCDescription { get; set; }

        // Project data section /////////////////////////////////////////
        [Display(Name = "Imp. order")]
        public int AoCImplementationOrder { get; set; }
        [Display(Name = "Record opened")]
        public DateTime? AoCRecordOpened { get; set; }
        [Display(Name = "Record closed")]
        public DateTime? AoCRecordClosed { get; set; }
        [Display(Name = "First contact")]
        public bool AoCFirstContact { get; set; }
        [Display(Name = "Date")]
        public DateTime? AoCFirstContactDate { get; set; }
        [Display(Name = "Live")]
        public bool AoCLive { get; set; }
        [Display(Name = "Live date")]
        public DateTime? AoCLiveDate { get; set; }
        [Display(Name = "BaU")]
        public bool AoCBaU { get; set; }
        [Display(Name = "BU date")]
        public DateTime? AoCBaUDate { get; set; }

        [Display(Name = "On hold")]
        public bool AoCOnHold { get; set; }
        [Display(Name = "Reason")]
        public string AoConHoldReason { get; set; }

        // Trak Use data section /////////////////////////////////////////
        public bool AoCMedicinesReconciliation { get; set; }
        public bool AoCMedicinesReconciliationRealTime { get; set; }
        public bool AoCOutpatientClinicManagedOnTrak { get; set; }
        public bool AoCOutpatientClinicManagedOnTrakInRealTime { get; set; }
        public bool AoCADTsManagedOnTrak { get; set; }
        public bool AoCADTsManagedOnTraIInRealTime { get; set; }
        public bool AoCIDLsProducedInTrak { get; set; }
        public bool AoCIDLsProducedInTrakInRealTime { get; set; }

        // Prescribing (recording) data section /////////////////////////////////////////
        public bool AoCWardRounds { get; set; }
        public bool AoCDoctorsRoom { get; set; }
        public bool AoCNursesStation { get; set; }
        public bool AoCOffice { get; set; }
        public string AoCOfficeText { get; set; }
        public bool AoCPOther { get; set; }
        public string AoCPOtherText { get; set; }

        // Medicines Administration (recording) data section /////////////////////////////////////////
        public bool AoCDrugRoundAtBedside { get; set; }
        public bool AoCDrugRoundFromCentralPoint { get; set; }
        public bool AoCPatientComesToCentralPoint { get; set; }
        public bool AoCMAOther { get; set; }
        public string AoCMAOtherText { get; set; }

        // Pharmacy Checking (recording) data section /////////////////////////////////////////
        public bool AoCBedside { get; set; }
        public bool AoCCentralPointInWard { get; set; }
        public bool AoCPCOher { get; set; }
        public string AoCPCOtherText { get; set; }


    }
}