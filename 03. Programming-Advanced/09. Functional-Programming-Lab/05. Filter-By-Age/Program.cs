using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{

    class Person
    {
        public string Name;

        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] patrs = line.Split(',');

                var person = new Person();

                person.Name = patrs[0];
                person.Age = int.Parse(patrs[1]);

                people.Add(person);
            }

            string filterName = Console.ReadLine();
            int ageToCompare = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = p => true;

            if (filterName == "younger")
            {
                filter = p => p.Age < ageToCompare;
            }
            else if (filterName == "older")
            {
                filter = p => p.Age >= ageToCompare;
            }

            var filteredPeople = people.Where(filter);

            string printName = Console.ReadLine();

            Func<Person, string> printFunc = p => p.Name + " " + p.Age;

            if (printName == "name age")
            {
                printFunc = p => p.Name + " - " + p.Age;
            }
            else if (printName == "name")
            {
                printFunc = p => p.Name;
            }

            var result = filteredPeople.Select(printFunc);

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}