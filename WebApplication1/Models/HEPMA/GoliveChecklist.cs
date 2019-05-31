using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class GoliveChecklist
    {
        public int GoliveChecklistId { get; set; }

        public bool GoliveChecklistUsersIdentified { get; set; }
        public DateTime? GoliveChecklistUsersIdentifiedDate { get; set; }
        public bool GoliveChecklistUsersTrained { get; set; }
        public DateTime? GoliveChecklistUsersTrainedDate { get; set; }
        public bool GoliveChecklistUsersSetup { get; set; }
        public DateTime? GoliveChecklistUsersSetupDate { get; set; }

        public bool GoliveChecklistIdentified { get; set; }
        public DateTime? GoliveChecklistIdentifiedDate { get; set; }
        public bool GoliveChecklistAgreedUse { get; set; }
        public DateTime? GoliveChecklistAgreedUseDate { get; set; }
        public bool GoliveChecklistSetupCurrent { get; set; }
        public DateTime? GoliveChecklistSetupCurrentDate { get; set; }
        public bool GoliveChecklistSetupNew { get; set; }
        public DateTime? GoliveChecklistSetupNewDate { get; set; }

        public bool GoliveChecklistPrescribing { get; set; }
        public DateTime? GoliveChecklistPrescribingDate { get; set; }
        public bool GoliveChecklistMedAdmin { get; set; }
        public DateTime GoliveChecklistMedAdminDate { get; set; }
        public bool GoliveChecklistPharmCheck { get; set; }
        public DateTime GoliveChecklistPharmCheckDate { get; set; }

        public bool GoliveChecklistContingencyAgreed { get; set; }
        public DateTime? GoliveChecklistContingencyAgreedDate { get; set; }

        public bool GoliveChecklistGo_Nogo { get; set; }
        public DateTime? GoliveChecklistGo_NogoDate { get; set; }

        public string GoliveChecklistGeneralNotes { get; set; }

        // EF Navigation items section /////////////////////////////////////////
        public virtual SiteLocation SiteLocation { get; set; }

        public virtual ICollection<SiteLocation> SiteLocations { get; set; }

        public int SiteLocationId { get; set; }

    }
}