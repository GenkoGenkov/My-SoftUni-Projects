using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < strings.Length; i++)
            {
                int swapPositions = random.Next(strings.Length);
                string temp = strings[i];
                strings[i] = strings[swapPositions];
                strings[swapPositions] = temp;
            }

            Console.WriteLine(string.Join("\n", strings));
        }
    }
}

