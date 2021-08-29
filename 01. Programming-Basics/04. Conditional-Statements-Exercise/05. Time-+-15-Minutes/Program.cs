using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes < 45)
            {
                minutes += 15;
            }
            else if (minutes >= 45)
            {
                minutes = (minutes + 15) - 60;
                hour += 1;
            }
            if (hour == 24)
            {
                hour = 0;
            }


            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
