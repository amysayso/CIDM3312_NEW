using System;

namespace buffteks.Models
{
    public class Client
    {
        //project list
        public string P_list {get; set;}
        //PK
        public int ProjectID {get; set;}
        //first name
        public string F_Name {get; set;}
        //last name
        public string L_Name {get; set;}
        //phone number
        public string Phone_Num {get; set;}
        //email
        public string Client_Email {get; set;}
        //organization
        public string Org {get; set;}
    }
}