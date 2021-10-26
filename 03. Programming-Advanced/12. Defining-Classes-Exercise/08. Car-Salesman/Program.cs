using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            List<Engine> engineModels = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine currentEngine = new Engine(engineInfo[0], engineInfo[1]);

                try
                {
                    if (Int32.TryParse(engineInfo[2], out _))
                    {
                        currentEngine.Displacement = engineInfo[2];
                    }
                    else
                    {
                        currentEngine.Efficiency = engineInfo[2];
                    }
                    if (Int32.TryParse(engineInfo[3], out _))
                    {
                        currentEngine.Displacement = engineInfo[3];
                    }
                    else
                    {
                        currentEngine.Efficiency = engineInfo[3];
                    }

                }
                catch (Exception)
                {
                }
                engineModels.Add(currentEngine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car currentCar = new Car(carInfo[0], engineModels.First(e => e.Model == carInfo[1]));

                try
                {
                    if (Int32.TryParse(carInfo[2], out _))
                    {
                        currentCar.Weight = carInfo[2];
                    }
                    else
                    {
                        currentCar.Color = carInfo[2];
                    }
                    if (Int32.TryParse(carInfo[3], out _))
                    {
                        currentCar.Weight = carInfo[3];
                    }
                    else
                    {
                        currentCar.Color = carInfo[3];
                    }
                }
                catch (Exception)
                {
                }
                cars.Add(currentCar);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; } = "n/a";
        public string Color { get; set; } = "n/a";
        public override string ToString()
        {
            return $"{Model}:\n  {Engine}\n  Weight: {Weight}\n  Color: {Color}";
        }
    }
    public class Engine
    {
        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
        }
        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; } = "n/a";
        public string Efficiency { get; set; } = "n/a";
        public override string ToString()
        {
            return $"{Model}:\n    Power: {Power}\n    Displacement: {Displacement}\n    Efficiency: {Efficiency}";
        }
    }
}
