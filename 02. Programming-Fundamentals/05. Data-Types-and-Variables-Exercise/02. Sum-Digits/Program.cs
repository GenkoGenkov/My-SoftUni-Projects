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
            int inputNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            while (inputNumber > 0)
            {
                sum += inputNumber % 10;
                inputNumber /= 10;

            }

            Console.WriteLine(sum);
        }
    }
}

