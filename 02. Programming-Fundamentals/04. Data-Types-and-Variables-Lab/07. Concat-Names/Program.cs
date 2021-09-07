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
            string firstName = Console.ReadLine();
            string latName = Console.ReadLine();
            string joiner = Console.ReadLine();

            Console.WriteLine($"{firstName}{joiner}{latName}");
        }
    }
}

