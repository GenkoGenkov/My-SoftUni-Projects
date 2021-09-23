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
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> count = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string lowerCase = words[i].ToLower();

                if (count.ContainsKey(lowerCase))
                {
                    count[lowerCase]++;
                }
                else
                {
                    count.Add(lowerCase, 1);
                }
            }

            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }    
}
