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
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int inputLitres = int.Parse(Console.ReadLine());

                if (sum + inputLitres > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                sum += inputLitres;
            }

            Console.WriteLine(sum);
        }
    }
}

