using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;

namespace FinalProject.Models
{
    public class DataSeed
    {
        public static void Seed(IApplicationBuilder app)
        {
            var db = app.ApplicationServices.GetRequiredService<AppDbContext>();

            db.Database.EnsureCreated();

            if (!db.Project.Any())
            {
                //Create 10 members
                //Create 2 Clients
                //Create 2 Projects
                var projects = new List<Project>
                {
                    new Project
                    {
                        ProjectName = "The Cupcake Co.",
                        ProjectDesc = "Selling cupcakes, cake, and goodies"
                    },

                    new Project 
                    {
                        ProjectName = "Bill's Place",
                        ProjectDesc = "Selling coffee, tea, and hot chocolate"
                    }
                };
                db.Project.AddRange(projects);
                db.SaveChanges();

                //Add Clients
                var clients = new List<Client>
                {
                    new Client
                    {
                        FirstName = "Bill",
                        LastName = "Co",
                        Phone = "806-123-4567",
                        Email = " BillCo@email.com",
                        CompanyName = "Bill Co"
                    },
                    new Client
                    {
                        FirstName = "The Cupcake",
                        LastName = "Co",
                        Phone = "806-859-6789",
                        Email = " TheCupcakeCo@email.com",
                        CompanyName = "The Cupcake"
                    },

                };

                db.Client.AddRange(clients);
                db.SaveChanges();

                //Data- Members
                var members = new List<Member>
                {
                    new Member
                    {
                        FirstName = "Raven",
                        LastName = "Baxter",
                        Phone = "758-484-9593",
                        Email = "Raven@email.com",
                        Major = "CIS"
                        
                    },

                     new Member
                    {
                        FirstName = "Cory",
                        LastName = "Baxter",
                        Phone = "234-987-9838",
                        Email = "Cory@email.com",
                        Major = "CIS"
                    },

                     new Member
                    {
                        FirstName = "John",
                        LastName = "Smith",
                        Phone = "765-444-8584",
                        Email = "John@email.com",
                        Major = "CIS"
                    },

                     new Member
                    {
                        FirstName = "William",
                        LastName = "Jones",
                        Phone = "567-993-2234",
                        Email = "William@email.com",
                        Major = "CIS"
                    },

                     new Member
                    {
                        FirstName = "Aaron",
                        LastName = "Doe",
                        Phone = "783-858-9942",
                        Email = "Aaron@email.com",
                        Major = "CIS"
                    },

                     new Member
                    {
                        FirstName = "Jacky",
                        LastName = "Smith",
                        Phone = "758-222-9993",
                        Email = "Jacky@email.com",
                        Major = "CIS"
                    },

                     new Member
                    {
                        FirstName = "Ann",
                        LastName = "Jones",
                        Phone = "774-838-8388",
                        Email = "Ann@email.com",
                        Major = "CIS"
                    },
                     new Member
                    {
                        FirstName = "Jeff",
                        LastName = "Salmon",
                        Phone = "454-774-9999",
                        Email = "Jeff@email.com",
                        Major = "CIS"
                    },
                     new Member
                    {
                        FirstName = "Bob",
                        LastName = "Burger",
                        Phone = "444-838-9292",
                        Email = "Bob@email.com",
                        Major = "CIS"
                    },
                     new Member
                    {
                        FirstName = "Pablo",
                        LastName = "West",
                        Phone = "832-039-3838",
                        Email = "Pablo@email.com",
                        Major = "CIS"
                    },
                };

                db.Member.AddRange(members);
                db.SaveChanges();

               if (db.ProjectList.Any())
               {
                   return;
               }

            //    var projectsFromDb = db.Project.ToList();
            //    var clientsFromDb = db.Client.ToList();
            //    var membersFromDb = db.Member.ToList();

               var projectLists = new List<ProjectList>
               {
                   //taking the project form above, the first client form above, and the first three students from above.
                   new ProjectList { ProjectID = projects[1].ProjectID,
                                     Project = projects[1],
                                     PersonID = clients[0].ID,
                                     Person = clients[0]
                                    },

                    new ProjectList { ProjectID = projects[1].ProjectID,
                                     Project = projects[1],
                                     PersonID = members[0].ID,
                                     Person = members[0]
                                    },
                    new ProjectList { ProjectID = projects[1].ProjectID,
                                     Project = projects[1],
                                     PersonID = members[1].ID,
                                     Person = members[1]
                                    },
                    new ProjectList { ProjectID = projects[1].ProjectID,
                                     Project = projects[1],
                                     PersonID = members[2].ID,
                                     Person = members[2]
                                    },

                    new ProjectList { ProjectID = projects[2].ProjectID,
                                     Project = projects[2],
                                     PersonID = clients[1].ID,
                                     Person = clients[1]
                                    },

                    new ProjectList { ProjectID = projects[2].ProjectID,
                                     Project = projects[2],
                                     PersonID = members[3].ID,
                                     Person = members[3]
                                    },
                    new ProjectList { ProjectID = projects[2].ProjectID,
                                     Project = projects[2],
                                     PersonID = members[4].ID,
                                     Person = members[4]
                                    },
                    new ProjectList { ProjectID = projects[2].ProjectID,
                                     Project = projects[2],
                                     PersonID = members[5].ID,
                                     Person = members[5]
                                    },
                    new ProjectList { ProjectID = projects[2].ProjectID,
                                     Project = projects[2],
                                     PersonID = members[6].ID,
                                     Person = members[6]
                                    },           
                   };

                   db.ProjectList.AddRange(projectLists);
                   db.SaveChanges();

               }


            }
        }
    }
