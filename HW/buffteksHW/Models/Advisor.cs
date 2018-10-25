using System;

namespace buffteksHW
{

	public class Advisor
	{
	//PK
	public int AdvisorID { get; set; }
	
	//firstname
	public string Advisor_FName {get; set;} 

	//lastname
	public string Advisor_LName {get; set;}

	//phone
	public string PhoneNumber {get; set;}

	//email
	public string Email {get; set;}


 public override string ToString()
        {
            return this.Advisor_FName + " " + this.Advisor_LName;
        }

	}
}
