using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class Client
    {
        //PK
        [Key]
        public int ClientID { get; set; }

        //Project List 
        public string ProjectList { get; set; }
        //FirstName
        public string ClientFirstName {get; set; }

        //LastName
        public string ClientLastName { get; set; }

        //Phone
        public string ClientPhoneNumber { get; set; } 

        //email
        public string ClientEmail {get; set; }      
    }
}