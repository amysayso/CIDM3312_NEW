using System;
using System.Linq;
using System.Collections.Generic;

namespace Inclass2
{
    public class Student
    {
        //PK
        public int StudentID { get; set; } 
        public string StudentName { get; set; } 
        public string LastName {get; set; } 
        public short age {get; set; } 
        public string Role {get; set; } 





        //FK
        public int TeamID {get; set;}

        public override string ToString()
        {
            return $"{StudentName} {LastName}"; 
        }

    }
}