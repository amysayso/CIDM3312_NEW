using System;
using System.Collections.Generic;
using System.Linq;
using buffteksHW;

namespace buffteksHW
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        //STUDENTS 
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Amy",
                                LastName = "Sayso",
                                PhoneNumber = "123-555-1234",
                                Email = "amysay@asdas.com",
                                Role = "Member"
                            },
                            new Student()
                            {
                                FirstName = "Ann",
                                LastName = "Smith",
                                PhoneNumber = "123-124-6684",
                                Email = "fdufaen@asdfa.com",
                                Role = "Member"
                            },
                            new Student()
                            {
                                FirstName = "John",
                                LastName = "Doe",
                                PhoneNumber = "333-555-8888",
                                Email = "sdfasga@dfgafg.dgf",
                                Role = "Member"
                            },                        
                        };

                        db.Students.AddRange(students);
                        db.SaveChanges();
                        Console.WriteLine("Student Added");                                            

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    }
                //CLIENT
                if(!db.Clients.Any())
                    {
                    List<Client> clients = new List<Client>()
                        {
                            new Client()
                            {
                                P_List = "adfasdf",
                                F_Name = "Client1",
                                L_Name = "Client1",
                                PhoneNumber = "124-141-1434",
                                Client_Email = "asfads@fdg",
                                Org = "dsfsfg"
                            },

                             new Client()
                            {
                                P_List = "kjkfkftu",
                                F_Name = "Client2",
                                L_Name = "Client2",
                                PhoneNumber = "777-155-1457",
                                Client_Email = "gsh@hshs.ege",
                                Org = "dfhsdhh"
                            },

                             new Client()
                            {
                                P_List = "hsgdhsgds",
                                F_Name = "Client3",
                                L_Name = "Client3",
                                PhoneNumber = "333-999-0000",
                                Client_Email = "sghsgjgs@hgd",
                                Org = "dsghsg"
                            }
                        };            
                        

                        db.Clients.AddRange(clients);
                        db.SaveChanges();   
                        Console.WriteLine("Clients Added");
                }                                         
            
                    else
                    {
                        var clients = db.Clients.ToList();
                        foreach(Client c in clients)
                        {
                            Console.WriteLine(c);
                        }
                    }

                //ADVISOR
                 if(!db.Advisors.Any())
                    {
                    List<Advisor> advisors = new List<Advisor>()
                        {
                            new Advisor()
                            {
                                Advisor_FName = "Adam",
                                Advisor_LName = "Smith",
                                PhoneNumber = "888-888-8889",
                                Email = "adgagafga@dfg.asd"
                            },

                            new Advisor()
                            {
                                Advisor_FName = "Jackie",
                                Advisor_LName = "Smith",
                                PhoneNumber = "808-511-3449",
                                Email = "aygjfya@dfg.asd"
                            },

                             new Advisor()
                            {
                                Advisor_FName = "Katie",
                                Advisor_LName = "Smith",
                                PhoneNumber = "818-222-3543",
                                Email = "aufhasgha@dfg.asd"
                            }
                        };            
                        

                        db.Advisors.AddRange(advisors);
                        db.SaveChanges();   
                        Console.WriteLine("Advisor Added");
                }                                         
            
                    else
                    {
                        var advisors = db.Advisors.ToList();
                        foreach(Advisor a in advisors)
                        {
                            Console.WriteLine(a);
                        }
                    }

                //TEAM
                 if(!db.Teams.Any())
                    {
                    List<Team> teams = new List<Team>()
                        {
                            new Team()
                            {
                                TeamID = 1,
                                TeamName = "Group1",
                                ProjectName = "Design"
                                
                            },
                            new Team()
                            {
                                TeamID = 2,
                                TeamName = "Group2",
                                ProjectName = "Update"
                                
                            },
                            new Team()
                            {
                                TeamID = 3,
                                TeamName = "Group3",
                                ProjectName = "Content"
                                
                            }
                        };            
                        

                        db.Teams.AddRange(teams);
                        db.SaveChanges();   
                        Console.WriteLine("Teams Added");
                }                                         
            
                    else
                    {
                        var teams = db.Teams.ToList();
                        foreach(Team t in teams)
                        {
                            Console.WriteLine(t);
                        }
                    }

                //PROJECTS
                 if(!db.Projects.Any())
                    {
                    List<Project> projects = new List<Project>()
                        {
                            new Project()
                            {
                                ProjectID = 1,
                                ProjectName = "Project1",
                                ProjectLeader = "Leader1",
                                RequiredHours = "5 hours",
                                Deadline = "Month"
                            },

                             new Project()
                            {
                                ProjectID = 2,
                                ProjectName = "Project2",
                                ProjectLeader = "Leader2",
                                RequiredHours = "10 hours",
                                Deadline = " 3 Month"
                            },

                            new Project()
                            {
                                ProjectID = 3,
                                ProjectName = "Project3",
                                ProjectLeader = "Leader3",
                                RequiredHours = "25 hours",
                                Deadline = " 5 Month"
                            },
                        };            
                        

                        db.Projects.AddRange(projects);
                        db.SaveChanges();   
                        Console.WriteLine("Project Added");
                }                                         
            
                    else
                    {
                        var projects = db.Projects.ToList();
                        foreach(Project p in projects)
                        {
                            Console.WriteLine(p);
                        }
                    }

                    //ORGANIZATION 
                     if(!db.Organizations.Any())
                    {
                    List<Organization> organizations = new List<Organization>()
                        {
                            new Organization()
                            {
                               
                               OrgAdvisor = "John Doe",
                               OrgEmail = "haghoafhgaf@jff.fga"
                            },

                              new Organization()
                            {
                              
                               OrgAdvisor = "Alexis Jones",
                               OrgEmail = "afgafdga@gsfga.fga"
                            },
                             new Organization()
                            {
                               
                               OrgAdvisor = "Rebecca Smith",
                               OrgEmail = "afasgafafganj@ghgg.fga"
                            },
                        };            
                        

                        db.Organizations.AddRange(organizations);
                        db.SaveChanges();   
                        Console.WriteLine("Organization Added");
                }                                         
            
                    else
                    {
                        var organizations = db.Organizations.ToList();
                        foreach(Organization o in organizations)
                        {
                            Console.WriteLine(o);
                        }
                    }
            

            //StudentTeam
             if(!db.StudentTeam.Any())
                    {
                    List<StudentTeam> studentTeams = new List<StudentTeam>()
                        {
                            new StudentTeam()
                            {
                               
                               StudentID = 1,
                               TeamID = 1,
                               Role= "Programmer"
                            },

                             new StudentTeam()
                            {
                               
                               StudentID = 2,
                               TeamID = 2,
                               Role= "Content"
                            },
                             new StudentTeam()
                            {
                               
                               StudentID = 3,
                               TeamID = 3,
                               Role= "Front-End Developer"
                            } 
                        };            
                        

                        db.StudentTeam.AddRange(studentTeams);
                        db.SaveChanges();   
                        Console.WriteLine("Student Team Added");
                }                                         
            
                    else
                    {
                        var StudentTeam = db.StudentTeam.ToList();
                        foreach(StudentTeam st in StudentTeam)
                        {
                            Console.WriteLine(st);
                        }
                    }
                

            //ClientOrg
             if(!db.ClientOrg.Any())
                    {
                    List<ClientOrg> clientOrgs = new List<ClientOrg>()
                        {
                            new ClientOrg ()
                            {
                               
                               ClientID= 1,
                               OrganizationID = 1
                               
                            },
                            new ClientOrg ()
                            {
                               
                               ClientID= 2,
                               OrganizationID = 2
                               
                            },
                            new ClientOrg ()
                            {
                               
                               ClientID= 3,
                               OrganizationID = 3
                               
                            },

                             
                        };            
                        

                        db.ClientOrg.AddRange(clientOrgs);
                        db.SaveChanges();   
                        Console.WriteLine("Client Organization Added");
                }                                         
            
                    else
                    {
                        var ClientOrg = db.ClientOrg.ToList();
                        foreach(ClientOrg co in ClientOrg)
                        {
                            Console.WriteLine(co);
                        }
                    }
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
         //MENU
         Console.WriteLine("Choose an option");
            do
            {
                Console.WriteLine("Enter 1 to read\n2 to update\n3 to search\n4 to sort\n5 to group\n6 to exit");
                Console.Write("> ");
                var menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        ReadStudent();
                        break;
                    case "2":
                        // add update student record call (ouside Main class bracket) i.e UpdateStudent();
                    case "3":
                        // add search student record call (outside Main class bracket) i.e SearchStudent();
                    case "4":
                        // add sort student record call (outside Main class bracket) i.e SortStudent();
                    case "5": 
                        // add group student record call (outside maub class bracket) i.e GroupStudent();
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Unknown option\n");
                        break;
                }
                
            } while (true);
            }
        }

        //READ
        public static void ReadStudent()
        {
            using (var db = new AppDbContext())
            {
            var student = db.Students;

            if (!student.Any())
            {
                Console.WriteLine("No records in the database\n");
            }
            else
            {
                foreach (var s in student)
                {
                    Console.WriteLine($"{s.FirstName} {s.LastName}");
                }   
            }  
            }
        }

        //UPDATE
        public static void UpdateStudentRole()
        {
            using ( var db = new AppDbContext())
            {
                var studentTeams = db.StudentTeam;

                if (!studentTeams.Any())
                    {
                        Console.WriteLine("No records in the database\n");
                    }
                    else
                    {

                    }        
            }
        }

    }
}
    



