using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputOne = char.Parse(Console.ReadLine());
            char inputTwo = char.Parse(Console.ReadLine());

            PrintTheCharsBetweenTwoChars(inputOne, inputTwo);
        }

        private static void PrintTheCharsBetweenTwoChars(char inputOne, char inputTwo)
        {
            int startCharacter = Math.Min(inputOne, inputTwo);
            int endCharacter = Math.Max(inputOne, inputTwo);

            for (int i = startCharacter + 1; i < endCharacter; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}

