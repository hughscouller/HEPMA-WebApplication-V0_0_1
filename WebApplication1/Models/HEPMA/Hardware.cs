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
        public int HId { get; set; }
        public string HType { get; set; }
        public string HAssetNumber { get; set; }
        public string HMacAddress { get; set; }
        public string HNetworkPort { get; set; }
        public bool HNPInUse { get; set; }
        public string HElectricalSocket { get; set; }
        public bool HESInUse { get; set; }
        public bool HTrailingSocket { get; set; }
        public int HLoIId { get; set; }

        public virtual LocationOfInterest LocationOfInterest { get; set; }
    }
}