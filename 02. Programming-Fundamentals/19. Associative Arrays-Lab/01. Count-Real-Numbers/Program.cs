using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            var numbersAsArrays = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbersAsArrays.Length; i++)
            {
                if (!numbers.ContainsKey(numbersAsArrays[i]))
                {
                    numbers.Add(numbersAsArrays[i], 0);
                }

                numbers[numbersAsArrays[i]]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }    
}
