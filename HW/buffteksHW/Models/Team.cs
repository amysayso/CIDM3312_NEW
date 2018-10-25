using System;

namespace buffteksHW
{

public class Team
	{
	//PK
	public int TeamID {get; set;}

	//Student-LIst FK 
	public string Student_List {get; set;}

	//Name
	public string TeamName {get; set;}

	//project - FK?
	public string ProjectName {get; set;}

     public override string ToString()
        {
            return this.TeamName + " = " + this.ProjectName;
        }

	}
}