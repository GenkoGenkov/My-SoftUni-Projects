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
            int firstDigit = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondDigit = int.Parse(Console.ReadLine());

            double result = Calculation(firstDigit, operation, secondDigit);

            Console.WriteLine(result);
        }

        static double Calculation(int firstDigit, string operation, int secondDigit)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstDigit + secondDigit;
                    break;
                case "-":
                    result = firstDigit - secondDigit;
                    break;
                case "*":
                    result = firstDigit * secondDigit;
                    break;
                case "/":
                    result = firstDigit / secondDigit;
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}

