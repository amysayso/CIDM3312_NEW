using System;
using System.Linq;

namespace Inclass2
{
    public class Commands
    {
    
    //WHERE PRACTICE
        //Students that are not seniors 
        public static void StudentsNotSeniors()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students.ToList();
                var notSeniors = students.Where (s => s.Role != "Senior");
                foreach(Student s in notSeniors)
                {
                    Console.WriteLine(s);
                }
                
            }
        }

        //first names begin with letters 'M' or lower
        public static void StudentM()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students.ToList();
                var studentM = students.Where ( s => s.StudentName.StartsWith("M"));
            }
        }


         //Last name begins with Letter 'L' or higher and whose first names are longer than 6 characters

         //Show all students who have taken CIDM 3350 previously


        //FIND PRACTICE
        

            //John
            public static void John()
            {
                using ( var db = new AppDbContext())
                {
                    var Student_John = db.Students.Where(s => s.StudentName == "John");
                    foreach(Student s in Student_John)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            //Alexander
            public static void Alexander()
            {
                using ( var db = new AppDbContext())
                {
                    var Student_Alex = db.Students.Where(s => s.StudentName == "Alexander");
                    foreach(Student s in Student_Alex)
                    {
                        Console.WriteLine(s);
                    }
                }
            }


            //shortest first name
            public static void ShortestFirstName()
            {
                using ( var db = new AppDbContext())
                {
                    var studentShortName = from s in db.Students
                                            orderby s.StudentName descending
                                            select s;
                        foreach(Student s in studentShortName)
                        {
                            Console.WriteLine(s);
                        }
                }
            }

            //shortest last name
            public static void ShortestLastName()
            {
                using ( var db = new AppDbContext())
                {
                    var studentLastName = from s in db.Students
                                            orderby s.LastName descending
                                            select s;
                        foreach(Student s in studentLastName)
                        {
                            Console.WriteLine(s);
                        }
                }
            }

            //shortest last name, but has the longest first name


        //SORT PRACTICE

            //sorted by first name
            public static void SortedFirstName()
            {
                using ( var db = new AppDbContext ())
                {
                    var SFN = from s in db.Students
                              orderby s.StudentName 
                              select s;
                    
                    Console.WriteLine(SFN);
                }
            }

            //sorted by last name descending
            public static void LastNameDESC()
            {
                using ( var db = new AppDbContext ())
                {
                    var LND = from s in db.Students
                              orderby s.LastName descending 
                              select s;

                    Console.WriteLine(LND);
                }
            }

            //sorted by role
            public static void SortedRole()
            {
                using (var db = new AppDbContext())
                {
                    var SR = from s in db.Students
                             orderby s.Role
                             select s;

                    Console.WriteLine(SR);
                 }
            }

            //sorted by senior and last name
            public static void SortedSeniorLN()
            {
                using (var db = new AppDbContext())
                {
                    var SSLN = from s in db.Students
                               orderby s.Role //&& s.LastName
                               select s; 
                }
            }

            //sorted NOT SENIORS and sorted by first name descending
            public static void notSeniorStudentNameDESC()
            {
                using ( var db = new AppDbContext ())
                {
                    var NSSND = from s in db.Students
                              orderby s.StudentName descending 
                              select s;

                    Console.WriteLine(NSSND);
                }
            }

        //GROUP PROJECT

            //all students grouped by class rank
            public static void GroupedClassRank()
            {
                using (var db = new AppDbContext())
                {
                    var GCR = from s in db.Students
                        group s by s.Role;
                    
                    foreach ( var classRole in GCR)
                    {
                        Console.WriteLine(GCR);
                    }
                }
            }
            
            //all students grouped by class rank and sorted by last name

            //connect to the database and show all students Grouped by the first letter of their last name and sorted by first name
    }
}