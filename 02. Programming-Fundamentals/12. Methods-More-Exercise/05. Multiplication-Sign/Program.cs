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
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int sum = numOne * numTwo * numThree;

            if (sum > 0)
            {
                Console.WriteLine("positive");
            }
            else if (sum < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}

