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
            int[] shootTargets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            int countTargets = 0;

            while (command != "End")
            {
                int targetIndex = int.Parse(command);

                if (targetIndex < 0 || targetIndex > shootTargets.Length - 1)
                {
                    command = Console.ReadLine();
                    continue;
                }

                int value = shootTargets[targetIndex];

                shootTargets[targetIndex] = -1;

                countTargets++;

                for (int i = 0; i < shootTargets.Length; i++)
                {

                    if (shootTargets[i] > value && shootTargets[i] != -1)
                    {
                        shootTargets[i] -= value;
                    }
                    else if (shootTargets[i] <= value && shootTargets[i] != -1)
                    {
                        shootTargets[i] += value;
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {countTargets} -> {string.Join(" ", shootTargets)}");
        }
    }
}

