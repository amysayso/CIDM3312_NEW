using System;

namespace buffteksHW
{
	public class Client 
	{

	   //Project List
	   public string P_List {get; set;}

 	        //PK
            public int ClientID {get; set;}

            //first name
            public string F_Name {get; set;}

            //last name
            public string L_Name {get; set;}

            //phone
            public string PhoneNumber {get; set;}

            //email
            public string Client_Email { get; set; }

            //organization 
            public string Org {get; set;}
        

        
       public override string ToString()
        {
            return this.F_Name + " " + this.L_Name;
        }

        
    }
}
