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
            Queue<string> customers = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    Console.WriteLine(string.Join("\n", customers));
                    customers.Clear();
                    input = Console.ReadLine();
                    continue;
                }

                customers.Enqueue(input);
                input = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
