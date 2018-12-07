using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class Project
    {
        //PK
        [Key]
        public int ID { get; set; }

        //Name
        [Display(Name = " Project Name ")]
        public string ProjectName {get; set; }

        //Description 
        [Display(Name = " Project Description ")]
        public string ProjectDesc {get; set;}

        public ICollection<ProjectList> Person {get; set;}

        public override string ToString()
        {
            return $"Project Name: {this.ProjectName}\nProject Description: {this.ProjectDesc}";
        }
    }
}