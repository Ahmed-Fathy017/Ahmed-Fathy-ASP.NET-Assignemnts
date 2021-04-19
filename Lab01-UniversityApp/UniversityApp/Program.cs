using System;
using UniversityApp.Data;
using UniversityApp.Domain;
using System.Collections;
using System.Collections.Generic;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*var DB = new UniversityDBContext();

            DB.Universitites.Add(new University() { Name = "AUC University", 
            Students = new List<Student> {new Student() { Name = "Ahmed", Grade = 80 },
             new Student() { Name = "Rana", Grade = 85 },
              new Student() { Name = "Reham", Grade = 90 }
            }});

            DB.SaveChanges();
            Console.WriteLine("Database updated successfully");*/

            var db = new UniversityDBContext();
            var university = db.Universitites.Find(4);
            Console.WriteLine(university.Name);

            var student = db.Students.Find(3);
            Console.WriteLine(student.Name);
        }
    }
}
