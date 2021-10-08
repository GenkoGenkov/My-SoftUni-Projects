using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> collection = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|");
                collection.Add(carInfo[0], new Car(int.Parse(carInfo[1]), int.Parse(carInfo[2])));
            }

            string[] command = Console.ReadLine().Split(" : ");

            while (command[0] != "Stop")
            {
                string model = string.Empty;
                int distance = 0;
                int fuel = 0;

                switch (command[0])
                {
                    case "Drive":
                        model = command[1];
                        distance = int.Parse(command[2]);
                        fuel = int.Parse(command[3]);

                        if (collection[model].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            collection[model].Fuel -= fuel;
                            collection[model].Mileage += distance;

                            Console.WriteLine($"{model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                            if (collection[model].Mileage >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {model}!");
                                collection.Remove(model);
                            }
                        }

                        break;

                    case "Refuel":

                        model = command[1];
                        fuel = int.Parse(command[2]);
                        collection[model].Fuel += fuel;

                        if (collection[model].Fuel > 75)
                        {
                            fuel -= collection[model].Fuel - 75;
                            collection[model].Fuel = 75;
                        }

                        Console.WriteLine($"{model} refueled with {fuel} liters");
                        break;

                    case "Revert":

                        model = command[1];
                        distance = int.Parse(command[2]);
                        collection[model].Mileage -= distance;

                        if (collection[model].Mileage < 10000)
                        {
                            collection[model].Mileage = 10000;
                            command = Console.ReadLine().Split(" : ");
                            continue;
                        }

                        Console.WriteLine($"{model} mileage decreased by {distance} kilometers");

                        break;
                }
                command = Console.ReadLine().Split(" : ");
            }

            foreach (var item in collection.OrderByDescending(c => c.Value.Mileage).ThenBy(c => c.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }

    class Car
    {
        public Car(int mileage, int fuel)
        {
            Mileage = mileage;
            Fuel = fuel;
        }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
