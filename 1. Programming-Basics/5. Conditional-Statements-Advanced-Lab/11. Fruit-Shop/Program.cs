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
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());



            double totalPrice = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    totalPrice = 2.50 * quantity;
                }
                else if (fruit == "apple")
                {
                    totalPrice = 1.20 * quantity;
                }
                else if (fruit == "orange")
                {
                    totalPrice = 0.85 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    totalPrice = 1.45 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    totalPrice = 2.70 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    totalPrice = 5.50 * quantity;
                }
                else if (fruit == "grapes")
                {
                    totalPrice = 3.85 * quantity;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    totalPrice = 2.70 * quantity;
                }
                else if (fruit == "apple")
                {
                    totalPrice = 1.25 * quantity;
                }
                else if (fruit == "orange")
                {
                    totalPrice = 0.90 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    totalPrice = 1.60 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    totalPrice = 3.00 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    totalPrice = 5.60 * quantity;
                }
                else if (fruit == "grapes")
                {
                    totalPrice = 4.20 * quantity;
                }
            }


            if (totalPrice > 0)
            {
                Console.WriteLine("{0:f2}", totalPrice);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
