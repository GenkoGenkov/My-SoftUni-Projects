using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int passedCars = 0;
            bool isHitted = false;

            Queue<string> cars = new Queue<string>();

            while (command != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    int currentGreenLight = greenLight;

                    while (cars.Count > 0 && currentGreenLight > 0)
                    {
                        string currentCar = cars.Dequeue();

                        if (currentGreenLight - currentCar.Length >= 0)
                        {
                            currentGreenLight -= currentCar.Length;
                            passedCars++;
                            continue;
                        }

                        if (currentGreenLight + freeWindow - currentCar.Length >= 0)
                        {
                            currentGreenLight = 0;
                            passedCars++;
                            continue;
                        }

                        string hittedChar = currentCar.Substring(currentGreenLight + freeWindow, 1);

                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {hittedChar}.");
                        isHitted = true;
                        Environment.Exit(0);
                    }
                }

                command = Console.ReadLine();
            }

            if (!isHitted)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
