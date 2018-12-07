using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
 
 public class ProjectList
    {
        public string PersonID { get; set; }
        public Person Person { get; set; }
        public string ProjectID { get; set; }
        public Project Project { get; set; }
    }
}