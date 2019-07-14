using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class NotesFieldLocationOfInterest
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Created on")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Note Type")]
        public string NoteType { get; set; }

        [Display(Name = "LoI ID")]
        public int LoIId { get; set; }

        [Display(Name = "Note")]
        public string Note { get; set; }

        public virtual LocationOfInterest locationOf { get; set; }


    }
}