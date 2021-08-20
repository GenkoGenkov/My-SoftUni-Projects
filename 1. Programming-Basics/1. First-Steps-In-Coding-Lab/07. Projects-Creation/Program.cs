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
            string name = Console.ReadLine();

            int project = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {project * 3} hours to complete {project} project/s.");
        }
    }
}