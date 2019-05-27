using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class NotesFieldHospitalSite
    {
        public int Id { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string NoteType { get; set; }
        public int HospitalId { get; set; }
        public string Note { get; set; }

        public virtual HospitalSite HospitalSite { get; set; }
    }
}