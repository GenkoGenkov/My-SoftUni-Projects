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
            string input = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    sum = sum + 1;
                }

                if (input[i] == 'e')
                {
                    sum = sum + 2;
                }

                if (input[i] == 'i')
                {
                    sum = sum + 3;
                }

                if (input[i] == 'o')
                {
                    sum = sum + 4;
                }

                if (input[i] == 'u')
                {
                    sum = sum + 5;
                }

            }

            Console.WriteLine(sum);
        }

    }
}
