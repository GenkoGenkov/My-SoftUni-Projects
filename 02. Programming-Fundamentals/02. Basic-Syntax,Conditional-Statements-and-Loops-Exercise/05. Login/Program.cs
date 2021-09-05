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
            string userName = Console.ReadLine();
            string password = string.Join("", userName.Reverse());



            for (int i = 0; i < 4; i++)
            {
                string inputPassword = Console.ReadLine();

                if (inputPassword == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }

                if (i == 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }

                if (inputPassword != password)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }
        }
    }
}

