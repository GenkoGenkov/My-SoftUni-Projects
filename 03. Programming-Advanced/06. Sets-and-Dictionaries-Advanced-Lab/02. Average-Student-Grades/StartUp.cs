using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace Christmas
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] parts = line.Split(' ');

                string name = parts[0];
                decimal grade = decimal.Parse(parts[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                }

                students[name].Add(grade);
            }

            foreach (var item in students)
            {
                Console.Write($"{item.Key} -> ");

                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {item.Value.Average():F2})");
            }
        }
    }
}

