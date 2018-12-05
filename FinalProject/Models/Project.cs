using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class Project
    {
        //PK
        [Key]
        public int ProjectID { get; set; }

        //Name
        public string Name {get; set; }

        
        //Required Hours
        public int RequiredHours { get; set; } 

        //deadline
        public DateTime deadline { get; set; }      
    }
}