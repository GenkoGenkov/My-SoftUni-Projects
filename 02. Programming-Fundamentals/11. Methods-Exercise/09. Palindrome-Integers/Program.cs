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
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isPalindrome = IsPalindrome(input);

                Console.WriteLine(isPalindrome);

                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string input)
        {
            string reverse = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            bool isPalindrome = input == reverse;

            return isPalindrome;
        }
    }
}

