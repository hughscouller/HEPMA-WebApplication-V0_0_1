using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class Hardware
    {
        [Key]
        [Display(Name = "Hardware ID")]
        public int HId { get; set; }
        [Display(Name = "Hardware Type")]
        public string HType { get; set; }
        [Display(Name = "Asset Number")]
        public string HAssetNumber { get; set; }
        [Display(Name = "MAC Address")]
        public string HMacAddress { get; set; }
        [Display(Name = "Network Port")]
        public string HNetworkPort { get; set; }
        [Display(Name = "NP in use")]
        public bool HNPInUse { get; set; }
        [Display(Name = "Electrical Socket")]
        public string HElectricalSocket { get; set; }
        [Display(Name = "ES in use")]
        public bool HESInUse { get; set; }
        [Display(Name = "Trailing Socket")]
        public bool HTrailingSocket { get; set; }
        [Display(Name = "LoI ID")]
        public int HLoIId { get; set; }

        public virtual NotesFeildLocationOfInterest LocationOfInterest { get; set; }
    }
}