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
            string line = Console.ReadLine();

            string[] numberAsStringList = line.Split(' ');

            Dictionary<double, int> numbers = new Dictionary<double, int>();

            foreach (var item in numberAsStringList)
            {
                double number = double.Parse(item);

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}

