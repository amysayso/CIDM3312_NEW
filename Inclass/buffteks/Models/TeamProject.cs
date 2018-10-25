using System;

namespace buffteks.Models
{
 public class TeamProject 
 {
     public int TeamID {
         
         get
         {
             if (this.TeamID == 3)
             {
                    return 9;
             }
             else{
                 return this.TeamID;
             }
         } 
         set
         {
             
         }

     }
         

     public Team TheTeam {get; set;}

     public int ProjectID {get; set;}

      public Project TheProject {get; set;}

 }   
}