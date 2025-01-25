using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolDatabaseGroupJoin
{
    // Represents a student with ID, Name, and associated Class ID
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
    }

    // Represents a class with ID and Name
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sample student data
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Student { StudentId = 2, StudentName = "Ayse", ClassId = 2 },
                new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
                new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
                new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 1 },
            };

            // Sample class data
            List<Class> classes = new List<Class>
            {
                new Class { ClassId = 1, ClassName = "Matematik" },
                new Class { ClassId = 2, ClassName = "Türkçe" },
                new Class { ClassId = 3, ClassName = "Kimya" },
            };

            // Group join query to list students by class
            var groupJoinResult = from cls in classes
                                  join std in students on cls.ClassId equals std.ClassId into studentGroup
                                  select new
                                  {
                                      ClassName = cls.ClassName,
                                      Students = studentGroup
                                  };

            // Display results
            foreach (var group in groupJoinResult)
            {
                Console.WriteLine($"Class: {group.ClassName}");
                if (group.Students.Any())
                {
                    foreach (var student in group.Students)
                    {
                        Console.WriteLine($"  - {student.StudentName}");
                    }
                }
                else
                {
                    Console.WriteLine("  No students in this class.");
                }
            }
        }
    }
}
