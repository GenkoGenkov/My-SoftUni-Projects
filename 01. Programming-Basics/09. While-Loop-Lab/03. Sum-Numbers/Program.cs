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
            double goalNUmber = double.Parse(Console.ReadLine());

            double sum = 0;
            double singleNumberInput = double.Parse(Console.ReadLine());

            while (true)
            {

                sum += singleNumberInput;

                if (sum >= goalNUmber)
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    singleNumberInput = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
