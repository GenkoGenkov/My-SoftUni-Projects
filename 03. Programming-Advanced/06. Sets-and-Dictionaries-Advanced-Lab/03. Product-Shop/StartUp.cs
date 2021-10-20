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
            SortedDictionary<string, Dictionary<string, double>> products = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Revision")
                {
                    break;
                }

                string[] parts = line.Split(',');

                string supermarket = parts[0];
                string productName = parts[1];
                double price = double.Parse(parts[2]);

                if (!products.ContainsKey(supermarket))
                {
                    products.Add(supermarket, new Dictionary<string, double>());
                }

                if (!products[supermarket].ContainsKey(productName))
                {
                    products[supermarket].Add(productName, price);
                }
                else
                {
                    products[supermarket][productName] = price;
                }
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product:{product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}

