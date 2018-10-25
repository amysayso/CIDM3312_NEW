using System;
using buffteks.Models;
using System.Linq;
using System.Collections.Generic;

namespace buffteks
{
    class Program
    {
        static void Main(string[] args)
        {
          using (var context = new AppDbContext())
          {
             

              try
              {
                //no matter what, delete and then create
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                if(!context.Student.Any())
                
                {
                    //inclass 
              List<Student> students = new List <Student>()
              
              {
                  new Student()
                  {
                  F_Name = "Amy",
                  L_Name = "Saysouriyosack",
                  PhoneNumber= "806-881-2881",
                  Email = "asaysoriyosack1@buffs.wtamu.edu",
                  Role = " Member "
              },

                new Student()
              {
                  F_Name = "Jay",
                  L_Name = "Doe",
                  PhoneNumber= "812-123-1234",
                  Email = "johndoe@buffs.wtamu.edu",
                  Role = " Member "
              },
                 new Student()
              {
                  F_Name = "Ann",
                  L_Name = "Smith",
                  PhoneNumber= "888-555-1234",
                  Email = "ASmith@buffs.wtamu.edu",
                  Role = " Member "
              },
              };

              //Student s = new Student()
              
              context.Student.AddRange(students);
              context.SaveChanges();

            }
            else
            {
                var Student = context.Student.ToList();
                foreach(Student s in Student)
                {
                    Console.WriteLine(s);
                }
            }

                 /* 
                  Client c = new Client ()
              {
                F_Name = "John",
                L_Name = " Smith",
                Phone_Num = " 123 -123- 1233",
                Client_Email = "asdfdng32@sdd.asd",
                Org = "adsfasd"
              };
              context.Client.Add(c);
              context.SaveChanges();
              }
                */
            }
              catch(Exception exp)
              {
                  Console.WriteLine(exp.Message);
              }

          }
        }
    }
}
