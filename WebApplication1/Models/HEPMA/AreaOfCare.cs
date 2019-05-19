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
        public string AoCType { get; set; }
        public string AocDescription { get; set; }

        // Project data section /////////////////////////////////////////
        public int AoCAoCImplementationOrder { get; set; }
        public DateTime? AoCRecordOpened { get; set; }
        public DateTime? AoCRecordClosed { get; set; }
        public bool AoCFirstContact { get; set; }
        public DateTime AoCFirstContactDate { get; set; }
        public bool AoCLive { get; set; }
        public DateTime? AoCLiveDate { get; set; }
        public bool AoCBaU { get; set; }
        public DateTime? AoCBaUDate { get; set; }
        public bool AoCOnHold { get; set; }
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