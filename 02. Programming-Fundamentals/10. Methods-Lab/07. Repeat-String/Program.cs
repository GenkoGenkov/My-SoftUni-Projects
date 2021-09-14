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
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = Output(text, n);

            Console.WriteLine(result);
        }

        static string Output(string text, int n)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += text;
            }
            return result;
        }
    }
}

