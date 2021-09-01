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
            int joineryNumber = int.Parse(Console.ReadLine());
            string kindOfJoinery = Console.ReadLine();
            string delivery = Console.ReadLine();

            double moneyForJoinery = 0;

            if (kindOfJoinery == "90X130")
            {
                moneyForJoinery = joineryNumber * 110;

                if (joineryNumber > 30 && joineryNumber <= 60)
                {
                    moneyForJoinery = moneyForJoinery * 0.95;
                }
                else if (joineryNumber > 60)
                {
                    moneyForJoinery = moneyForJoinery * 0.92;
                }

            }
            else if (kindOfJoinery == "100X150")
            {
                moneyForJoinery = joineryNumber * 140;

                if (joineryNumber > 40 && joineryNumber <= 80)
                {
                    moneyForJoinery = moneyForJoinery * 0.94;
                }
                else if (joineryNumber > 80)
                {
                    moneyForJoinery = moneyForJoinery * 0.90;
                }
            }
            else if (kindOfJoinery == "130X180")
            {
                moneyForJoinery = joineryNumber * 190;

                if (joineryNumber > 20 && joineryNumber <= 50)
                {
                    moneyForJoinery = moneyForJoinery * 0.93;
                }
                else if (joineryNumber > 50)
                {
                    moneyForJoinery = moneyForJoinery * 0.88;
                }
            }
            else if (kindOfJoinery == "200X300")
            {
                moneyForJoinery = joineryNumber * 250;

                if (joineryNumber > 25 && joineryNumber <= 50)
                {
                    moneyForJoinery = moneyForJoinery * 0.91;
                }
                else if (joineryNumber > 50)
                {
                    moneyForJoinery = moneyForJoinery * 0.86;
                }
            }

            if (delivery == "With delivery")
            {
                moneyForJoinery = moneyForJoinery + 60;
            }

            if (joineryNumber > 99)
            {
                moneyForJoinery = moneyForJoinery * 0.96;
            }

            if (joineryNumber < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else if (true)
            {
                Console.WriteLine($"{moneyForJoinery:F2} BGN");
            }
        }
    }
}

