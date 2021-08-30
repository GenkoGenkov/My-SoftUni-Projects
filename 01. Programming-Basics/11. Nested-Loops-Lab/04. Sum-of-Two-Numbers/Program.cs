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
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNsumber = int.Parse(Console.ReadLine());

            int combinationCounter = 0;


            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int a = firstNumber; a <= secondNumber; a++)
                {
                    combinationCounter++;

                    if (i + a == magicNsumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {a} = {magicNsumber})");
                        return;
                    }

                }

            }
            Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNsumber}");
        }
    }
}
