﻿using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcTaskManager.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; } 
        public string ProjectName{ get; set; }
        [DisplayFormat(DataFormatString ="d/M/yyyy")]
        public DateTime DateOfStart{ get; set; } 
        public int Teamsize { get; set; } 
    }
}
