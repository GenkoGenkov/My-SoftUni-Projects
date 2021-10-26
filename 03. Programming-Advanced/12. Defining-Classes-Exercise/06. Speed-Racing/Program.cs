using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> vehicle = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                string carModel = data[0];
                int carFuel = int.Parse(data[1]);
                double gasForOneKilometer = double.Parse(data[2]);

                Car currentCar = new Car(carModel, carFuel, gasForOneKilometer);

                if (!vehicle.Contains(currentCar))
                {
                    vehicle.Add(currentCar);
                }                
            }

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                string[] drive = input;

                string car = drive[1];
                int amountOfKm = int.Parse(drive[2]);

                vehicle.First(c => c.Model == car).Drive(amountOfKm);


                input = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(Environment.NewLine, vehicle));
        }
    }

    public class Car
    {

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; } = 0;

        public void Drive(double distance)
        {
            double fuelConsumed = distance * FuelConsumptionPerKilometer;

            if (FuelAmount - fuelConsumed >= 0)
            {
                FuelAmount -= fuelConsumed;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TravelledDistance}";
        }
    }
}
