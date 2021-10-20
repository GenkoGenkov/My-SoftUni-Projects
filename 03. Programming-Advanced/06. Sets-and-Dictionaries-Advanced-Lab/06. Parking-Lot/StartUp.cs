using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace Christmas
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> parking = new HashSet<string>();

            while (input != "END")
            {
                string[] data = input.Split(',');

                string action = data[0];
                string carNumber = data[1];

                if (action == "IN")
                {
                    parking.Add(carNumber);
                }
                else if (action == "OUT")
                {
                    parking.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parking.Count > 0)
            {
                Console.WriteLine(string.Join("\n", parking));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}

