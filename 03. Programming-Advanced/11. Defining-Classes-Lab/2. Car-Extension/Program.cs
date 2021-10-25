using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);

            Console.WriteLine(car.WhoAmI());
        }
    }

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            FuelQuantity = 0;
            FuelConsumption = 0;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) 
            
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public string Make { get; set; }
        public string  Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double fuelConsumed = distance * (fuelConsumption / 100);

            if (fuelQuantity - fuelConsumed >= 0)
            {
                fuelQuantity -= fuelConsumed;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Make: {make}\nModel: {model}\nYear: {year}\nFuelQuantity: {fuelQuantity}");

            return sb.ToString();
        }
    }    
}