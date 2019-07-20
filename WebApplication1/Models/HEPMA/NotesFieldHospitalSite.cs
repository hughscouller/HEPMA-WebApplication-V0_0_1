using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.HEPMA
{
    public class NotesFieldHospitalSite
    {
        public int Id { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Created on")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Note Type")]
        public string NoteType { get; set; }

        [Display(Name = "Hosp ID")]
        public int HospitalId { get; set; }

        [Display(Name = "Note")]
        public string Note { get; set; }

        public virtual HospitalSite HospitalSite { get; set; }
    }
}