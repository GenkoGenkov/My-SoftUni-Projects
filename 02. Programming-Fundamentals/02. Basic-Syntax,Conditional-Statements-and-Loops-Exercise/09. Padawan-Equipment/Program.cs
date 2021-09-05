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
            double ammountOfMoney = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalSum = priceLightsabers * Math.Ceiling(studentCount * 1.1) + priceOfRobes * studentCount + priceOfBelts * (studentCount - (studentCount / 6));

            if (ammountOfMoney >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - ammountOfMoney:F2}lv more.");
            }
        }
    }
}

