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
            string favBook = Console.ReadLine();
            string input = Console.ReadLine();

            int count = 0;

            while (input != "No More Books")
            {
                if (input == favBook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }

                input = Console.ReadLine();
                count++;

            }

            if (input == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
