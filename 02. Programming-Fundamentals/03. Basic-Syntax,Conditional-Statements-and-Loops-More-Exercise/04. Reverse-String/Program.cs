using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string password = string.Join("", input.Reverse());

            Console.WriteLine(password);
        }
    }
}

