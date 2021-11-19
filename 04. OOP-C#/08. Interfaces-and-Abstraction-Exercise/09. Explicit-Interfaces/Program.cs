using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split();

                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                Citizen current = new Citizen(name, country, age);

                Console.WriteLine(current);

                command = Console.ReadLine();
            }
        }
    }
}