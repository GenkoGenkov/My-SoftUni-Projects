using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();

            List<Student> filledList = new List<Student>();

            while (command != "end")
            {
                string[] data = command.Split();
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string city = data[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                filledList.Add(student);

                command = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            foreach (Student item in filledList)
            {
                if (item.City == cityName)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }
}
