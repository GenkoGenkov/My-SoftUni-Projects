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

            int result = Vowels(input);

            Console.WriteLine(result);
        }

        private static int Vowels(string input)
        {
            int sum = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    sum++;
                }
                else if (input[i] == 'e')
                {
                    sum++;
                }
                else if (input[i] == 'i')
                {
                    sum++;
                }
                else if (input[i] == 'o')
                {
                    sum++;
                }
                else if (input[i] == 'u')
                {
                    sum++;
                }
                else if (input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}

