using System;
using System.Collections.Generic;
using System.Linq;
using buffteksFinal;

namespace buffteksFinal
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
                            new Student()
                            {
                                FirstName = "Jayden",
                                LastName = "Black",
                                PhoneNumber = "333-555-8888",
                                Email = "email4@dfgafg.dgf",
                                Role = "President"
                            }, 
                            new Student()
                            {
                                FirstName = "Will",
                                LastName = "Mills",
                                PhoneNumber = "333-555-8888",
                                Email = "email5@dfgafg.dgf",
                                Role = "Vice-president"
                            },                       
                        };

                        db.Students.AddRange(students);
                        db.SaveChanges();
                        Console.WriteLine("Student Added");                                            

                    }
                    
                    else
                    {
                        
                        var students = db.Students.ToList();

                        var studentsFiltered = students.Where(s => s.FirstName.Length >= 5);
                       var studentsFiltered = from s in db.Students
                                               where s.FirstName.Length >= 5
                                               select s;
                        

                       // var studentsGroup = db.Students.GroupBy( s => s.Role);

                        /*
                        foreach( var roleGroup in studentsGroup)
                        {
                            Console.WriteLine($"Role Group: {roleGroup.Key}");
                        }

                        foreach(Student s in studentsGroup)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    */

                    //var studentsOrdered =db.Students.OrderBy (s => s.LastName);
                    //for each
                    
        
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}
