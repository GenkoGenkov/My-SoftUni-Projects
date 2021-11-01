
using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                var data = Console.ReadLine().Split();

                if (data[0] == "END")
                {
                    break;
                }

                persons.Add(new Person(data[0], int.Parse(data[1]), data[2]));
            }

            int index = int.Parse(Console.ReadLine()) - 1;

            int equal = 0;
            int notEqual = 0;

            foreach (var item in persons)
            {
                if (persons[index].CompareTo(item) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notEqual} {persons.Count}");
            }
        }
    }
}
