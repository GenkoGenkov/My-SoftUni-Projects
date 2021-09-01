using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxGoals = int.MinValue;
            string bestPlayer = "";

            while (true)
            {
                string player = Console.ReadLine();

                if (player == "END")
                {
                    break;

                }

                int goals = int.Parse(Console.ReadLine());

                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = player;
                }

                if (maxGoals >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{bestPlayer} is the best player!");

            if (maxGoals >= 3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else if (true)
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}

