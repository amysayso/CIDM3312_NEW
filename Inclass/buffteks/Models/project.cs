using System;

namespace buffteks.Models
{
 public class Project 
 {
     //PK
     public Project P_Key {get; set;}

     //name
     public Project P_Name {get; set;}
     //leader = FK team lead
     public Project P_Leader {get; set;}
     //required hours 
     public Project Required_Hours {get; set;}
     //client - FK Client 
     public Project client {get; set;}

     //deadline - DateTime
     public Project deadline {get; set;}
 }   
}