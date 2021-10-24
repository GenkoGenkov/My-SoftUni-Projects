using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> nameLenght = (name, lenght) => name.Length <= lenght;

            int maxLenght = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split().Where(x => nameLenght(x, maxLenght)).ToArray();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}