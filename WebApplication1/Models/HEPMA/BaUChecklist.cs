using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class BaUChecklist
    {
        public int BaUChecklistId { get; set; }

        public bool BaUChecklistSuccessfulGoLive { get; set; }
        public string BaUChecklistSuccessfulGoliveNotes { get; set; }

        public bool BaUChecklistTrainingComplete { get; set; }
        public string BaUChecklistTrainingCompleteNotes { get; set; }

        public bool BaUChecklistUserSetup { get; set; }
        public string BaUChecklisUserSetupNotes { get; set; }

        public bool BaUChecklistHardwareSetup { get; set; }
        public string BaUChecklistHardwareSetupNotes { get; set; }

        public bool BaUChecklistHardwareUseAgreed { get; set; }
        public string BaUChecklistHardwareUseAgreedNotes { get; set; }

        public bool BaUChecklistContingencyAgreed { get; set; }
        public string BaUChecklistContingencyAgreedNotes { get; set; }

        // EF Navigation items section /////////////////////////////////////////
        public virtual SiteLocation SiteLocation { get; set; }

        public virtual ICollection<SiteLocation> SiteLocations { get; set; }

        public int SiteLocationId { get; set; }
    }
}