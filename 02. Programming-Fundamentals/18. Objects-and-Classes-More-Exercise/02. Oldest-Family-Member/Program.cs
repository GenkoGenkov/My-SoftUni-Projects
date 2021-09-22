using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Family newFamily = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] memberData = Console.ReadLine().Split();

                Person currentPerson = new Person(memberData[0], int.Parse(memberData[1]));

                newFamily.AddMembers(currentPerson);
            }

            Console.WriteLine(newFamily.OldestMember());
        }
    }

    class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }
        public List<Person> Members { get; set; }

        public void AddMembers(Person person)
        {
            Members.Add(person);
        }

        public Person OldestMember()
        {
            Members = Members.OrderByDescending(m => m.Age).ToList();
            return Members[0];
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}





