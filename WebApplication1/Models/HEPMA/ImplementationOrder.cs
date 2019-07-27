using System.Collections.Generic;

namespace WebApplication1.Models.HEPMA
{
    public class ImplementationOrder
    {

        public int ImpOrderId { get; set; }
        public int ImpOrderValue { get; set; }

        public int AoCId { get; set; }

        public virtual List<AreaOfCare> AreasOfCare { get; set; }


    }
}