using System;
using System.Linq;
using System.Collections.Generic;

namespace Objects_and_Classes
{


    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splitted = input.Split();
                string name = splitted[0];
                string id = splitted[1];
                int age = int.Parse(splitted[2]);

                Student student = new Student();
                student.Name = name;
                student.Id = id;
                student.Age = age;

                students.Add(student);

                input = Console.ReadLine();
            }

            for (int i = 0; i < students.Count; i++)
            {
                int minIndex = i;

                for (int j = i; j < students.Count; j++)
                {
                    if (students[j].Age < students[minIndex].Age)
                    {
                        minIndex = j;
                    }
                }

                Student temp = students[minIndex];
                students[minIndex] = students[i];
                students[i] = temp;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} with ID: {student.Id} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }
}
