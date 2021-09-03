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
            int finalGoal = int.Parse(Console.ReadLine());

            int goal = finalGoal - 30;
            int jumpCounter = 0;
            int badResultCounter = 0;

            while (goal <= finalGoal)
            {
                int jumps = int.Parse(Console.ReadLine());
                jumpCounter++;

                if (jumps > goal)
                {
                    goal += 5;
                    badResultCounter = 0;
                }
                else
                {
                    badResultCounter++;
                }

                if (badResultCounter == 3)
                {
                    Console.WriteLine($"Tihomir failed at {goal}cm after {jumpCounter} jumps.");
                    return;
                }
            }

            if (goal > finalGoal)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {goal - 5}cm after {jumpCounter} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir failed at {goal}cm after {jumpCounter} jumps.");
            }
        }
    }
}

