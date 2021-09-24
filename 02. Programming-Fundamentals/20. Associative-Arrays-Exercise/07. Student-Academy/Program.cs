using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> statistics = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!statistics.ContainsKey(name))
                {
                    statistics.Add(name, new List<double>());
                    statistics[name].Add(grade);
                    continue;
                }

                statistics[name].Add(grade);
            }

            statistics = statistics.Where(s => s.Value.Average() >= 4.50).ToDictionary(s => s.Key, s => s.Value);

            foreach (var item in statistics.OrderByDescending(s => s.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
            }
        }
    }
}