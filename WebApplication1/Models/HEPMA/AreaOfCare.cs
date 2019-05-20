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
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? AoCRecordOpened { get; set; }

        [Display(Name = "Record closed")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? AoCRecordClosed { get; set; }

        [Display(Name = "First contact")]
        public bool AoCFirstContact { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AoCFirstContactDate { get; set; }

        [Display(Name = "Live")]
        public bool AoCLive { get; set; }

        [Display(Name = "Live date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AoCLiveDate { get; set; }

        [Display(Name = "BaU")]
        public bool AoCBaU { get; set; }

        [Display(Name = "BU date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AoCBaUDate { get; set; }

        [Display(Name = "On hold")]
        public bool AoCOnHold { get; set; }

        [Display(Name = "Reason")]
        public string AoConHoldReason { get; set; }

        // Trak Use data section /////////////////////////////////////////

        [Display(Name = "Med Rec")]
        public bool AoCMedicinesReconciliation { get; set; }

        [Display(Name = "Med Rec - real time")]
        public bool AoCMedicinesReconciliationRealTime { get; set; }

        [Display(Name = "OP managed on Trak")]
        public bool AoCOutpatientClinicManagedOnTrak { get; set; }

        [Display(Name = "OP managed on Trak - real time")]
        public bool AoCOutpatientClinicManagedOnTrakInRealTime { get; set; }

        [Display(Name = "ADTs managed on Trak")]
        public bool AoCADTsManagedOnTrak { get; set; }

        [Display(Name = "ADTs managed on Trak - real time")]
        public bool AoCADTsManagedOnTraIInRealTime { get; set; }

        [Display(Name = "IDLs managed on Trak")]
        public bool AoCIDLsProducedInTrak { get; set; }

        [Display(Name = "IDLs managed on Trak - real time")]
        public bool AoCIDLsProducedInTrakInRealTime { get; set; }


        // Prescribing (recording) data section /////////////////////////////////////////

        [Display(Name = "Ward rounds")]
        public bool AoCWardRounds { get; set; }

        [Display(Name = "Doctors room")]
        public bool AoCDoctorsRoom { get; set; }

        [Display(Name = "Nurses station")]
        public bool AoCNursesStation { get; set; }

        [Display(Name = "Office")]
        public bool AoCOffice { get; set; }

        [Display(Name = "Office where")]
        public string AoCOfficeText { get; set; }

        [Display(Name = "Other location")]
        public bool AoCPOther { get; set; }

        [Display(Name = "Other location where")]
        public string AoCPOtherText { get; set; }


        // Medicines Administration (recording) data section /////////////////////////////////////////


        [Display(Name = "Drug round - bedside")]
        public bool AoCDrugRoundAtBedside { get; set; }

        [Display(Name = "Drug round - central point")]
        public bool AoCDrugRoundFromCentralPoint { get; set; }

        [Display(Name = "Patient to central point")]
        public bool AoCPatientComesToCentralPoint { get; set; }

        [Display(Name = "Other")]
        public bool AoCMAOther { get; set; }

        [Display(Name = "Other notes")]
        public string AoCMAOtherText { get; set; }


        // Pharmacy Checking (recording) data section /////////////////////////////////////////

        [Display(Name = "Bedside")]
        public bool AoCBedside { get; set; }

        [Display(Name = "Central point on ward")]
        public bool AoCCentralPointInWard { get; set; }

        [Display(Name = "Other")]
        public bool AoCPCOher { get; set; }

        [Display(Name = "Other where")]
        public string AoCPCOtherText { get; set; }


    }
}