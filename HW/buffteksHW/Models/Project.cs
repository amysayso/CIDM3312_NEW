using System;

namespace buffteksHW
{
	public class Project 
	{
 	   //PK
            public int ProjectID {get; set;}

            //Project Name
            public string ProjectName {get; set;}

            //Project leader
            public string ProjectLeader {get; set;}

            //Project Required Hours
            public string RequiredHours {get; set;}

            //client- FK
            public string Client { get; set; }

            //deadline
            public string Deadline {get; set; }

             public override string ToString()
        {
            return this.ProjectLeader + " = " + this.ProjectName;
        }

        }
}
