using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Inclass2;

namespace Inclass2
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

                    
                        //STUDENTS 
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                
                                StudentName= "Amy",
                                LastName = "Saysouriyosack",
                                age = 20,
                                Role = "Junior"

                            },
                            new Student()
                            {
                                
                                StudentName= "Laith ",
                                LastName = "Alfaloujeh",
                                age = 22,
                                Role = "Senior"
                                
                            },     
                             new Student()
                            {
                                
                                StudentName= "Mekkala ",
                                LastName = "Bourapa",
                                age = 22,
                                Role = "Junior"
                                
                            },     
                             new Student()
                            {
                                
                                StudentName= "Charles",
                                LastName = " Coufal ",
                                age = 35,
                                Role = "Senior"
                                
                            },     
                             new Student()
                            {
                                
                                StudentName= "John",
                                LastName = "Cunningham",
                                age = 26,
                                Role = "Senior"
                                
                            },     
                             new Student()
                            {
                                
                                StudentName= "Michael",
                                LastName = "Hayes",
                                age = 19,
                                Role = "Junior"
                                
                            },     
                             new Student()
                            {
                                
                                StudentName= "Aaron",
                                LastName = "Hebert",
                                age = 21,
                                Role = "Junior"
                                
                            },     
                             new Student()
                            {
                                
                                StudentName= "Yi Fu",
                                LastName = "Ji",
                                age = 24,
                                Role = "Senior"
                                
                            },     
                             new Student()
                            {
                                
                                StudentName= "Todd",
                                LastName = "Kile",
                                age = 24,
                                Role = "Junior"
                                
                            },
                            new Student()
                            {
                                
                                StudentName= "Mara",
                                LastName = "Kinoff",
                                age = 20,
                                Role = "Senior"
                                
                            },  
                            new Student()
                            {
                                
                                StudentName= "Cesareo",
                                LastName = "Lona",
                                age = 37,
                                Role = "Senior"
                                
                            },  
                            new Student()
                            {
                                
                                StudentName= "Michael",
                                LastName = "Matthews ",
                                age = 29,
                                Role = "Senior"
                                
                            },  
                            new Student()
                            {
                                
                                StudentName= "Mason ",
                                LastName = "McCollum",
                                age = 25,
                                Role = "Senior"
                                
                            },  
                            new Student()
                            {
                                
                                StudentName= "Alexander ",
                                LastName = "McDonald",
                                age = 30,
                                Role = "Junior"
                                
                            },   
                             new Student()
                            {
                                
                                StudentName= "Phelps",
                                LastName = "Merrell ",
                                age = 32,
                                Role = "Junior"
                                
                            },       
                             new Student()
                            {
                                
                                StudentName= "Quan",
                                LastName = "Nguyen",
                                age = 27,
                                Role = "Senior"
                                
                            },       
                             new Student()
                            {
                                
                                StudentName= "Alexander",
                                LastName = "Roder",
                                age = 56,
                                Role = "Junior"
                                
                            },       
                             new Student()
                            {
                                
                                StudentName= "Claudia",
                                LastName = "Silva",
                                age = 21,
                                Role = "Sophmore"
                                
                            },       
                             new Student()
                            {
                                
                                StudentName= "Gabriela",
                                LastName = "Valenzuela",
                                age = 32,
                                Role = "Freshman"
                                
                            },       
                             new Student()
                            {
                                
                                StudentName= "Kayla",
                                LastName = "Washington",
                                age = 30,
                                Role = "Freshman"
                                
                            },  
                            new Student()
                            {
                                
                                StudentName= "Matthew",
                                LastName = "Webb",
                                age = 24,
                                Role = "Freshman"
                                
                            },
                            new Student()
                            {
                                
                                StudentName= "Cory",
                                LastName = "Williams",
                                age = 45,
                                Role = "Senior"
                                
                            },         

                        };
                    if(!db.Students.Any())
                    {
                        db.Students.AddRange(students);
                        db.SaveChanges();
                        Console.WriteLine("Student Added");                                            
                    }
                    else
                    {
                        var studentList= db.Students.ToList();
                        
                        foreach(Student s in studentList)
                        {
                            Console.WriteLine(s);
                        }
                    }
                
                    Commands.StudentsNotSeniors();
                    Commands.StudentM();
                    Commands.John();
                    Commands.Alexander();
                    Commands.ShortestFirstName();
                    Commands.ShortestLastName();
                    Commands.SortedFirstName();
                    Commands.LastNameDESC();
                    Commands.SortedRole();
                    Commands.SortedSeniorLN();
                    Commands.notSeniorStudentNameDESC();
                    Commands.GroupedClassRank();
                    
                }
            
            
                        //var studentsFiltered = students.Where(s => s.FirstName.Length >= 5);
                        //var studentsFiltered = from s in db.Students
                        //                       where s.FirstName.Length >= 5
                              //                 select s;
                        

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
