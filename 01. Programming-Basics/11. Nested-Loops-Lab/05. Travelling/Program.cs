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
            string destination = "";
            double money = 0;

            while (true)
            {
                destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                double neededMoney = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < neededMoney)
                {
                    money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }

                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}

