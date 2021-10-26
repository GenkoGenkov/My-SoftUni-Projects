using System;
using System.Collections.Generic;
using System.Linq;

namespace DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.Calculate(firstDate, secondDate);

            Console.WriteLine(days);
        }
    }

    public static class DateModifier
    {
        public static int Calculate(string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime dateTwo = DateTime.Parse(secondDate);

            int days = Math.Abs((dateOne - dateTwo).Days);

            return days;
        }
    }
}
