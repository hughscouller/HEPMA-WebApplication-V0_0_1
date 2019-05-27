﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HEPMA
{
    public class NotesFieldHospitalSite
    {
        public int Id { get; set; }

        public string CreatedBy { get; set; }

        [Display(Name = "Created on")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? CreatedOn { get; set; }
        public string NoteType { get; set; }
        public int HospitalId { get; set; }
        public string Note { get; set; }

        public virtual HospitalSite HospitalSite { get; set; }
    }
}