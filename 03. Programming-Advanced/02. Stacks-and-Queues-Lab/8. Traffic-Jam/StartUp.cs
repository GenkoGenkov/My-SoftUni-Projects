using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int passedCars = 0;

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                else if (line == "green")
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            var car = cars.Dequeue();

                            Console.WriteLine(car + " passed!");

                            passedCars++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(line);
                }
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
