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
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string inputString = Console.ReadLine();

            while (true)
            {

                if (inputString == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
                else
                {
                    inputString = Console.ReadLine();
                }

            }
        }
    }
}
