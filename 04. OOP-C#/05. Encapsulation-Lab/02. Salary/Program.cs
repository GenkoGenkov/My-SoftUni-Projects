using PersonsInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int counter = 0; counter < peopleCount; counter++)
            {
                string[] personInfo = Console.ReadLine().Split();

                string firstName = personInfo[0];
                string lastName = personInfo[1];
                int age = int.Parse(personInfo[2]);
                decimal salary = decimal.Parse(personInfo[3]);

                Person person = new Person(firstName, lastName, age, salary);
                people.Add(person);
            }

            decimal bonus = decimal.Parse(Console.ReadLine());

            people.ForEach(p => p.IncreaseSalary(bonus));
            people.ForEach(p => Console.WriteLine(p));
        }
    }
}