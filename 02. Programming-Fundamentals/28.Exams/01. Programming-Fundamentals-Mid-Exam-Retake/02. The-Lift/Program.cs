using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            List<int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < lift.Count; i++)
            {
                while (lift[i] < 4)
                {
                    if (people <= 0)
                    {
                        break;
                    }

                    people--;
                    lift[i]++;
                }
            }

            if (people <= 0 && !lift.All(l => l == 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people > 0 && lift.All(l => l == 4))
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people <= 0 && lift.All(l => l == 4))
            {
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}