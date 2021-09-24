using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Dictionary<string, int> resources = new Dictionary<string, int>();

                string res = Console.ReadLine();

                while (res != "stop")
                {
                    int quantity = int.Parse(Console.ReadLine());

                    if (!resources.ContainsKey(res))
                    {
                        resources.Add(res, quantity);
                        res = Console.ReadLine();
                        continue;
                    }

                    resources[res] += quantity;

                    res = Console.ReadLine();
                }

                foreach (var item in resources)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
