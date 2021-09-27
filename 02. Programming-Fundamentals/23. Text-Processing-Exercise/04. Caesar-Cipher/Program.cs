using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder encrypted = new StringBuilder(Console.ReadLine());

            StringBuilder cypher = new StringBuilder();

            foreach (var item in encrypted.ToString())
            {
                cypher.Append((char)(item + 3));
            }

            Console.WriteLine(cypher);
        }
    }
}