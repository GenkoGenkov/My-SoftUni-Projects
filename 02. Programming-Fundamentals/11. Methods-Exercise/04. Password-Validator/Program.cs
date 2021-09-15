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
            string password = Console.ReadLine();

            ChechIfPasswordIsValid(password);
        }

        static void ChechIfPasswordIsValid(string password)
        {
            int digitCounter = 0;
            bool isValidLenght = password.Length >= 6 && password.Length <= 10;
            bool isValidSymbol = true;

            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    isValidSymbol = false;
                }

                if (char.IsDigit(password[i]))
                {
                    digitCounter++;
                }
            }

            bool containsTwoDigits = digitCounter >= 2;

            if (!isValidLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isValidSymbol)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!containsTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValidLenght && isValidSymbol && containsTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}

