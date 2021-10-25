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
            string input;

            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                List<string> tireSet = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                Tire[] currentTireSet = new Tire[4];

                for (int i = 0; i < 4; i++)
                {
                    Tire currentTire = new Tire(int.Parse(tireSet[0]), double.Parse(tireSet[1]));
                    currentTireSet[i] = currentTire;
                    tireSet.RemoveAt(0);
                    tireSet.RemoveAt(0);
                }

                tires.Add(currentTireSet);
            }

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine currentEngine = new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]));
                engines.Add(currentEngine);
            }

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = engines[int.Parse(carInfo[5])];
                Tire[] tireSet = tires[int.Parse(carInfo[6])];
                Car currentCar = new Car(carInfo[0], carInfo[1], int.Parse(carInfo[2]), double.Parse(carInfo[3]), double.Parse(carInfo[4]), engine, tireSet);
                cars.Add(currentCar);
            }

            cars = cars.Where(c =>
                c.Year >= 2017 && c.Engine.HorsePower > 330 && c.Tires.Sum(t => t.Pressure) >= 9 &&
                c.Tires.Sum(t => t.Pressure) <= 10).ToList();

            foreach (var car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }
        public string Make
        {
            get => make;
            set { make = value; }
        }
        public string Model
        {
            get => model;
            set { model = value; }
        }

        public int Year
        {
            get => year;
            set { year = value; }
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get => fuelConsumption;
            set { fuelConsumption = value; }
        }

        public Engine Engine { get => engine; set { engine = value; } }
        public Tire[] Tires { get => tires; set { tires = value; } }

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
            sb.Append($"Make: {make}\nModel: {model}\nYear: {year}\nHorsePowers: {engine.HorsePower}\nFuelQuantity: {fuelQuantity}");
            return sb.ToString();
        }
    }
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
        public int HorsePower { get => horsePower; set { horsePower = value; } }
        public double CubicCapacity { get => cubicCapacity; set { cubicCapacity = value; } }
    }
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        public int Year { get => year; set { year = value; } }
        public double Pressure { get => pressure; set { pressure = value; } }
    }
}