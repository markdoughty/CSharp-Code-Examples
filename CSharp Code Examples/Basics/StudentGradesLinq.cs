using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class Student
    {
        public required string Name { get; set; }
        public int Grade { get; set; }
    }

    class StudentGradesLinq
    {
        //Authors: Will Anderson
        //Filters and sorts a list of student grades using LINQ instead of manual loops
        public static void run()
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Grade = 82 },
                new Student { Name = "Bilal", Grade = 55 },
                new Student { Name = "Chen", Grade = 91 },
                new Student { Name = "Dorota", Grade = 63 },
                new Student { Name = "Ewan", Grade = 47 },
                new Student { Name = "Fatima", Grade = 78 }
            };

            Console.WriteLine("All students:");
            foreach (Student s in students)
                Console.WriteLine(s.Name + ": " + s.Grade);

            //anything 60 or above is a pass, ordered highest first
            var passed = students.Where(s => s.Grade >= 60).OrderByDescending(s => s.Grade);

            Console.WriteLine("");
            Console.WriteLine("Passed (60+):");
            foreach (Student s in passed)
                Console.WriteLine(s.Name + ": " + s.Grade);

            double avg = students.Average(s => s.Grade);
            Student top = students.OrderByDescending(s => s.Grade).First();
            int passCount = students.Count(s => s.Grade >= 60);

            Console.WriteLine("");
            Console.WriteLine("Average grade: " + avg);
            Console.WriteLine("Top student: " + top.Name);
            Console.WriteLine(passCount + " out of " + students.Count + " passed");
        }
    }
}
