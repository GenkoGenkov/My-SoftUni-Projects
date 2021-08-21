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
            int numOfPages = int.Parse(Console.ReadLine());

            double pagesPerHour = double.Parse(Console.ReadLine());

            int days = int.Parse(Console.ReadLine());

            double totalTime = numOfPages / pagesPerHour;

            double hoursPerDay = totalTime / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}