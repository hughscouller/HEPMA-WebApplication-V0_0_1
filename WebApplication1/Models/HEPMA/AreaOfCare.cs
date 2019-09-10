using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.HEPMA
{
    public class AreaOfCare
    {

        [Key]
        public int AoCId { get; set; }

        // EF Navigation items section /////////////////////////////////////////
        public virtual SiteLocation SiteLocation { get; set; }

        public virtual ICollection<SiteLocation> SiteLocations { get; set; }

        public int SiteLocationId { get; set; }

        // ///////////////////////////////////////////////////////////////////
        // General data section ////////////////////////////////////////////////
        // //////////////////////////////////////////////////////////////////
        #region
        [Display(Name = "In scope")]
        public bool InScope { get; set; }

        [Display(Name = "Name")]
        public string AoCName { get; set; }

        [Display(Name = "Care Setting")]
        public string AoCType { get; set; }

        [Display(Name = "Description")]
        public string AoCDescription { get; set; }

        //// Project data ////// ///////////////////////////////////////////////

        [Display(Name = "Planned go-live date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? AoCPlannedGoLiveDate { get; set; }

        // Project data section ////////////////////////////////////////////////

        [Display(Name = "GL date agreed AoC")]
        public bool AoCPlannedGoLiveDateAgreedAoC { get; set; }

        [Display(Name = "Record opened")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? AoCRecordOpened { get; set; }

        [Display(Name = "Record closed")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? AoCRecordClosed { get; set; }

        //[Display(Name = "First contact")]
        //public bool AoCFirstContact { get; set; }

        [Display(Name = "First contact date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? AoCFirstContactDate { get; set; }

        [Display(Name = "Live")]
        public bool AoCLive { get; set; }

        [Display(Name = "Live date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? AoCLiveDate { get; set; }

        [Display(Name = "BaU")]
        public bool AoCBaU { get; set; }

        [Display(Name = "BU date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? AoCBaUDate { get; set; }

        [Display(Name = "On hold")]
        public bool AoCOnHold { get; set; }

        [Display(Name = "Reason")]
        public string AoConHoldReason { get; set; }

        [Display(Name = "Out of scope")]
        public bool NoLongerInScope { get; set; }

        [Display(Name = "Reason")]
        public string NoLongerInScopeReason { get; set; }

        // Trak Use data section //////////////////////////////////////////////

        [Display(Name = "Med Rec")]
        public bool AoCMedicinesReconciliation { get; set; }

        [Display(Name = "Med Rec - real time")]
        public bool AoCMedicinesReconciliationRealTime { get; set; }

        [Display(Name = "OP on Trak")]
        public bool AoCOutpatientClinicManagedOnTrak { get; set; }

        [Display(Name = "OP on Trak - real time")]
        public bool AoCOutpatientClinicManagedOnTrakInRealTime { get; set; }

        [Display(Name = "ADTs on Trak")]
        public bool AoCADTsManagedOnTrak { get; set; }

        [Display(Name = "ADTs on Trak - real time")]
        public bool AoCADTsManagedOnTraIInRealTime { get; set; }

        [Display(Name = "IDLs on Trak")]
        public bool AoCIDLsProducedInTrak { get; set; }

        [Display(Name = "IDLs on Trak - real time")]
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

        [Display(Name = "Pat. to central point")]
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
        #endregion
        // ///////////////////////////////////////////////////////////////////
        // tab 2 - AoC Assessment ////////////////////////////////////////////
        // ///////////////////////////////////////////////////////////////////
        #region
        [Display(Name = "Good to go")]
        public bool AoCAssessmentGoodToGo { get; set; }

        [Display(Name = "Good to Go date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? AoCAssessmentGoodToGoDate { get; set; }

        [Display(Name = "IT Literacy")]
        public string AoCAssessmentITLiteracy { get; set; }
        [Display(Name = "Use of Trak")]
        public string AoCAssessmentUseOfTrak { get; set; }
        [Display(Name = "Hardware Quality")]
        public string AoCAssessmentHardwareQuality { get; set; }

        [Display(Name = "Hardware Location")]
        public string AoCAssessmentHardwareLocation { get; set; }
        [Display(Name = "Business Process")]
        public string AoCAssessmentBusinessProcessDifference { get; set; }
        [Display(Name = "General Note")]
        public string AoCAssessmentGeneralNotes { get; set; }
        #endregion
        // ///////////////////////////////////////////////////////////////////
        // tab 3 - AoC Go live checklist  ////////////////////////////////////////////
        // ///////////////////////////////////////////////////////////////////
        #region

        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Users Identified
        [Display(Name = "Users Identified")]
        public bool GoliveChecklistUsersIdentified { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Users Identified Date
        [Display(Name = "Users Identified")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistUsersIdentifiedDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist UsersTrained
        [Display(Name = "Users Trained")]
        public bool GoliveChecklistUsersTrained { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist UsersTrained Date
        [Display(Name = "Users Trained Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistUsersTrainedDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Users Setup
        [Display(Name = "Users Setup")]
        public bool GoliveChecklistUsersSetup { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Users Setup date
        [Display(Name = "Users Setup Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistUsersSetupDate { get; set; }



        //public bool GoliveChecklistIdentified { get; set; }

        //public DateTime? GoliveChecklistIdentifiedDate { get; set; }


        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Agreed Use
        [Display(Name = "Agreed Business Process")]
        public bool GoliveChecklistAgreedUse { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Agreed Use Date
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistAgreedUseDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Setup Current
        [Display(Name = "Setup Current Users")]
        public bool GoliveChecklistSetupCurrent { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Setup Current Date
        [Display(Name = "Setup Current Users")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistSetupCurrentDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Setup New
        [Display(Name = "Setup New")]
        public bool GoliveChecklistSetupNew { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Setup New Date
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistSetupNewDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Prescribing
        [Display(Name = "Prescribing")]
        public bool GoliveChecklistPrescribing { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Prescribing Date
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistPrescribingDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Med Admin
        [Display(Name = "Med Admin")]
        public bool GoliveChecklistMedAdmin { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Med Admin Date
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistMedAdminDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Pharm Check
        [Display(Name = "pharm Check")]
        public bool GoliveChecklistPharmCheck { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Pharm Check
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistPharmCheckDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Contingency Agreed
        [Display(Name = "Contingency Agreed")]
        public bool GoliveChecklistContingencyAgreed { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Contingency Agreed Date
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistContingencyAgreedDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Go No-go
        [Display(Name = "Go/No-go")]
        public bool GoliveChecklistGo_Nogo { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist Go No-go Date
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? GoliveChecklistGo_NogoDate { get; set; }
        // /////////////////////////////////////////////////////////////////////////////// GoliveChecklist General Notes
        [Display(Name = "General Note")]
        public string GoliveChecklistGeneralNotes { get; set; }
        #endregion
        // ///////////////////////////////////////////////////////////////////
        // tab 4 - AoC BaU checklist  ////////////////////////////////////////////
        // ///////////////////////////////////////////////////////////////////
        #region
        [Display(Name = "Successful Go-live")]
        public bool BaUChecklistSuccessfulGoLive { get; set; }
        [Display(Name = "Notes")]
        public string BaUChecklistSuccessfulGoliveNotes { get; set; }

        [Display(Name = "Training Complete")]
        public bool BaUChecklistTrainingComplete { get; set; }
        [Display(Name = "Notes")]
        public string BaUChecklistTrainingCompleteNotes { get; set; }

        [Display(Name = "User Setup")]
        public bool BaUChecklistUserSetup { get; set; }
        [Display(Name = "Notes")]
        public string BaUChecklisUserSetupNotes { get; set; }

        [Display(Name = "Hardware Setup")]
        public bool BaUChecklistHardwareSetup { get; set; }
        [Display(Name = "Notes")]
        public string BaUChecklistHardwareSetupNotes { get; set; }

        [Display(Name = "Hardware Use Agreed")]
        public bool BaUChecklistHardwareUseAgreed { get; set; }
        [Display(Name = "Notes")]
        public string BaUChecklistHardwareUseAgreedNotes { get; set; }

        [Display(Name = "Contingency Agreed")]
        public bool BaUChecklistContingencyAgreed { get; set; }
        [Display(Name = "Notes")]
        public string BaUChecklistContingencyAgreedNotes { get; set; }
        #endregion
    }
}