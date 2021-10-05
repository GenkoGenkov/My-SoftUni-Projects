using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int allEmployeeEfficiency = firstEmployee + secondEmployee + thirdEmployee;

            int hours = 0;

            while (students > 0)
            {
                students -= allEmployeeEfficiency;
                hours++;

                if (hours % 4 == 0 && hours >= 4)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}

