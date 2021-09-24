using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {

                string[] inputInfo = input.Split();

                string name = inputInfo[0];
                double price = double.Parse(inputInfo[1]);
                int quantity = int.Parse(inputInfo[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new double[2]);
                }

                double previousQ = products[name][1];
                double[] priceQ = new double[] { price, previousQ + quantity };
                products[name] = priceQ;

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                double total = item.Value[0] * item.Value[1];

                Console.WriteLine($"{item.Key} -> {total:F2}");
            }
        }
    }
}