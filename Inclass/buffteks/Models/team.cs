using System;

namespace buffteks.Models
{
 public class Team
 {
     //PK
     public Team P_key {get; set;}
     //Student list - FK
     public Team Stu_List {get; set;}
     //name
     public Team name {get; set;}
     //projects - FK?? 
     public Team projects {get; set;}
 }   
}