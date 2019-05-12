using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class AreaOfCare
    {
        // meta data section /////////////////////////////////////////
        [Key]
        public int Id { get; set; }

        [Display(Name = "AoC Type (IP/OP)")]
        public string AocType { get; set; } // inpation / outpatient

        [Display(Name = "AoC Name")]
        public string Name { get; set; }
        [Display(Name = "AoC Description")]
        public string Description { get; set; }
        [Display(Name = "AoC General Notes")]
        public string Notes { get; set; }

        [Display(Name = "AoC Status")]
        public string Status { get; set; } // Pre-contact   pre-contact data gathering    Planned go-live    Actual go-live    BaU handover

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "First contact date")]
        public DateTime? FirstContactDate { get; set; }
        [Display(Name = "FCD Notes")]
        public string FirstContactNotes { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Planned go-live date")]
        public DateTime? PlannedGoLiveDate { get; set; }
        [Display(Name = "PGD Note")]
        public string PlannedGoLiveNotes { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Actual go-live date")]
        public DateTime? ActualGoLiveDate { get; set; }
        [Display(Name = "AGD Notes")]
        public string ActualGoLiveNotes { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "BaU handover date")]
        public DateTime? BauHandoverDate { get; set; }
        [Display(Name = "BaU Notes")]
        public string BauHandoverNotes { get; set; }

        [Display(Name = "AoC Notes")]
        public string AoCGeneralNotes { get; set; }

        // ////////////////////////////////////////////////////////////
        [Display(Name = "Sitel Location")]
        public virtual SiteLocation SiteLocation { get; set; }
        public int SiteLocationId { get; set; }

        // //////////////////////////////////////////////////////////
        // Business process section

        // use of Trak
        [Display(Name = "ADT's on Trak")]
        public bool ADTs { get; set; }                      // Y/N
        [Display(Name = "In real time")]
        public bool ADTsRealTime { get; set; }
        [Display(Name = "ADT Notes")]
        public string ADTsNotes { get; set; }

        [Display(Name = "OP Clinic managed on trak")]
        public bool OPCLinic { get; set; }                  // Y/N
        [Display(Name = "OP managed in real time")]
        public bool OPClinicRealTIme { get; set; }
        [Display(Name = "OP clinic notes")]
        public string OPClinicNotes { get; set; }

        // med rec
        public bool MedRec { get; set; }                    // Y/N
        public string MedRecWho { get; set; }
        public string MedRecWhere { get; set; }
        public string MedRecWhen { get; set; }

        public string MedRecNotes { get; set; }

        // Prescribing of medication
        public bool PrescWardRounds { get; set; }           // Y/N
        public string PrescWardRoundsNotes { get; set; }

        public bool PrescMDTs { get; set; }                 // Y/N
        public string PrescMDTsNotes { get; set; }

        public bool PrescNursesOffice { get; set; }         // Y/N
        public string PrescNursesOfficeNotes { get; set; }

        public bool PrescOther { get; set; }                // Y/N
        public string PrescOtherNotes { get; set; }

        public bool PrescUsersEpr { get; set; }                  // Y/N
        public string PrescUsersEprNotes { get; set; }

        public string PrescGeneralNotes { get; set; }

        // Administering and recording of medication
        public bool DrugRoundBedsideRecording { get; set; }
        public bool DrugRoundCentralPoint { get; set; }
        public bool PatToCentralPoint { get; set; }
        public bool Other { get; set; }
        public string MedAdminNotes { get; set; }

        public bool MedAdminUsersEpr { get; set; }                  // Y/N
        public string MedAdminUsersEprNotes { get; set; }

        // Pharmacy clinical check
        public bool PharmCheck { get; set; }
        public bool PharmCheckBedsite { get; set; }
        public bool PharmCheckOther { get; set; }
        public string PharmCheckNotes { get; set; }

        public bool PharmChecUsersEpr { get; set; }                  // Y/N
        public string PharmChecEprNotes { get; set; }

    }
}