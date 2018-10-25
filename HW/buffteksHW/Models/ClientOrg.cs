using System;

namespace buffteksHW
{
	public class ClientOrg
	{


 	        //PK&FK
            public int ClientID {get; set;}

            //PK&FK
            public int OrganizationID {get; set;}

            public Client Client {get; set;}

            public Organization Organization {get; set;}

            //organization 
            public string Org {get; set;}
        

        
       public override string ToString()
        {
            return this.ClientID + " " + this.OrganizationID;
        }

        
    }
}