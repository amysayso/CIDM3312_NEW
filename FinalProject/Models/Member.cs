using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class Member
    {
        //PK
        [Key]
        public int memberID { get; set; }

        //FirstName
        public string FirstName {get; set; }

        //LastName
        public string LastName { get; set; }

        //Phone
        public string PhoneNumber { get; set; } 

        //email
        public string Email {get; set; }      
    }
}