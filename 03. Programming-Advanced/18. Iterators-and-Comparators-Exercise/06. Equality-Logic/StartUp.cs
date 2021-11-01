using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                var person = new Person(data[0], int.Parse(data[1]));

                sortedSet.Add(person);
                hashSet.Add(person);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
