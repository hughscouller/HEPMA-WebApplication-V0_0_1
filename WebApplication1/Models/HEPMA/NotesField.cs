using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public enum NoteType { General, Contact}

    public class NotesField
    {

        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public string NoteType { get; set; }
        public string Note { get; set; }
        public int AreaOfCareId { get; set; }

        public AreaOfCare AreaOfCare { get; set; }

        //public List<AreaOfCare> AreasOfCare { get; set; }
    }
}