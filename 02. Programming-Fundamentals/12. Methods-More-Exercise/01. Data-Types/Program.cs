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
            string typeOfVaruable = Console.ReadLine();
            string value = Console.ReadLine();

            Clculations(typeOfVaruable, value);
        }

        private static void Clculations(string typeOfVaruable, string value)
        {


            if (typeOfVaruable == "int")
            {
                int result = 0;

                result = int.Parse(value) * 2;
                Console.WriteLine(result);

            }
            else if (typeOfVaruable == "real")
            {
                double resultOfDouble = 0;

                resultOfDouble = double.Parse(value) * 1.5;
                Console.WriteLine($"{resultOfDouble:F2}");
            }
            else if (typeOfVaruable == "string")
            {
                Console.WriteLine($"${value}$");
            }
        }
    }
}

