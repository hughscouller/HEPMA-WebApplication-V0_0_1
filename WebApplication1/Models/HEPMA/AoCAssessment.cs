using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class AoCAssessment 
    {

        public int AoCAssessmentId { get; set; }
        public bool AoCAssessmentGoodToGo { get; set; }
        public DateTime? AoCAssessmentGoodToGoDate { get; set; }
        
        public string AoCAssessmentITLiteracy { get; set; }
        public string AoCAssessmentUseOfTrak { get; set; }

        public string AoCAssessmentHardwareQuality { get; set; }
        public string AoCAssessmentHardwareQuantity { get; set; }
        public string AoCAssessmentHardwareLocation { get; set; }

        public string AoCAssessmentBusinessProcessDifference { get; set; }

        public string AoCAssessmentGeneralNotes { get; set; }

        // EF Navigation items section /////////////////////////////////////////
        public virtual SiteLocation SiteLocation { get; set; }

        public virtual ICollection<SiteLocation> SiteLocations { get; set; }

        public int SiteLocationId { get; set; }
    }
}