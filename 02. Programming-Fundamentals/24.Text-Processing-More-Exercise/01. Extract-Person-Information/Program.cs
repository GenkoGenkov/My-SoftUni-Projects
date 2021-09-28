using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder info = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string individual = Console.ReadLine();

                int indexNameStart = individual.IndexOf('@');
                int indexNameEnd = individual.IndexOf('|');

                string name = individual.Substring(indexNameStart + 1, indexNameEnd - indexNameStart - 1);

                int indexAgeStart = individual.IndexOf('#');
                int indexAgeEnd = individual.IndexOf('*');

                string age = individual.Substring(indexAgeStart + 1, indexAgeEnd - indexAgeStart - 1);

                info.Append($"{name} is {age} years old.\n");
            }

            Console.WriteLine(info);
        }
    }
}