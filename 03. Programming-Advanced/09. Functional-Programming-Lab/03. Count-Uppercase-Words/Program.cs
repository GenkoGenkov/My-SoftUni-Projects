using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var upperLetters = words.Where(word => char.IsUpper(word[0]));

            foreach (var item in upperLetters)
            {
                Console.WriteLine(item);
            }
        }
    }
}
