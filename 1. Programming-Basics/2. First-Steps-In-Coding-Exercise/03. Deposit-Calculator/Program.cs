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
            double deposit = double.Parse(Console.ReadLine());

            int deadline = int.Parse(Console.ReadLine());

            double annualInterestPercent = double.Parse(Console.ReadLine());

            double interest = deposit * (annualInterestPercent / 100);

            double interestPerMonth = interest / 12;

            double sum = deposit + deadline * interestPerMonth;

            Console.WriteLine(sum);
        }
    }
}