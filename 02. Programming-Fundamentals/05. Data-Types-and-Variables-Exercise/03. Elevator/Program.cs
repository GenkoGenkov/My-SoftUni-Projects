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
            double people = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(people / capacity));
        }
    }
}

