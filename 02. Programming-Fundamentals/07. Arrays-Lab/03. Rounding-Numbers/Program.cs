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
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == -0)
                {
                    array[i] = 0;
                }
                int roundedNumber = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{array[i]} => {roundedNumber}");
            }
        }
    }
}

