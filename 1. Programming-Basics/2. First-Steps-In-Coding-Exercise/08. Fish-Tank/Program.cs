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
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double totalLiters = volume * 0.001;
            double newPercent = percent * 0.01;

            double result = totalLiters * (1 - newPercent);
            Console.WriteLine($"{result}");
        }
    }
}