using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            int numOfDays = int.Parse(Console.ReadLine());
            int numOfBakers = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfWaffles = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());

            double incomePerDayPerBaker = numOfCakes * 45 + numOfWaffles * 5.80 + numOfPancakes * 3.20;

            double totalIncome = incomePerDayPerBaker * numOfDays * numOfBakers;

            totalIncome = totalIncome - totalIncome * 1 / 8;

            Console.WriteLine(totalIncome);
        }
    }
}