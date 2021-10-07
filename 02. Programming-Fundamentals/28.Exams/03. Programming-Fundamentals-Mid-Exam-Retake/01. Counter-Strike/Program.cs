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
            int energy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int wins = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    return;
                }

                energy -= distance;
                wins++;

                if (wins % 3 == 0)
                {
                    energy += wins;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
        }
    }
}

