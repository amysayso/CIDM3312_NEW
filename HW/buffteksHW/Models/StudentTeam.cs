using System;

namespace buffteksHW
{
    public class StudentTeam
    {
        //PK/FK
        public int StudentID{ get; set; }
        //PK/FK
        public int TeamID {get; set;}
        //TEAM
        public Team Team {get; set;}

        //student
        public Student Student {get; set;}
       
        //role
        public string Role { get; set; }

        public override string ToString()
        {
            return  this.TeamID + " " + this.StudentID;
        }

    }

}
