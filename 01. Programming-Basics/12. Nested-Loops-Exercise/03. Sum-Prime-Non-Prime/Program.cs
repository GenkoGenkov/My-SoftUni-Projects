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
            string command = Console.ReadLine();

            int sumOfPrime = 0;
            int sumOfNonePrime = 0;

            while (command != "stop")
            {
                int number = int.Parse(command);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;

                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }
                    }

                    if (count == 2)
                    {
                        sumOfPrime += number;
                    }
                    else
                    {
                        sumOfNonePrime += number;
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonePrime}");
        }
    }
}

