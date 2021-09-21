using System;
using System.Linq;
using System.Collections.Generic;


namespace exersiceArrays
{
    class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentData = Console.ReadLine().Split();

                Students currentStudent = new Students(studentData[0], studentData[1], double.Parse(studentData[2]));
                students.Add(currentStudent);
            }

            students = students.OrderByDescending(st => st.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    class Students
    {
        public Students(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:f2}";
        }
    }
}