using System;

namespace buffteks.Models
{
   
        public class Student 
        {
            //PK
            public int StudentID {get; set;}
            //first name
            public string F_Name {get; set;}
            //last name
            public string L_Name {get; set;}
            //phone
            public string PhoneNumber {get; set;}
            //email
            public string Email { get; set; }
            //role 
            public string Role {get; set;}
        }
    
}
