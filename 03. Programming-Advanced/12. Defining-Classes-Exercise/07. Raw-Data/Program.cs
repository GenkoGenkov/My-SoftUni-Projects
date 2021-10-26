using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split();

                string name = inputData[0];
                int engineSpeed = int.Parse(inputData[1]);
                int enginePower = int.Parse(inputData[2]);
                int cargoWeight = int.Parse(inputData[3]);
                string cargoType = inputData[4];

                List<Tire> tires = new List<Tire>();

                for (int tireIndex = 5; tireIndex <= 12; tireIndex += 2)
                {
                    double tirePressure = double.Parse(inputData[tireIndex]);
                    int tireAge = int.Parse(inputData[tireIndex + 1]);

                    Tire tire = new Tire(tireAge, tirePressure);
                    tires.Add(tire);
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Car car = new Car(name, engine, cargo, tires);

                cars.Add(car);
            }

            string typeCargo = Console.ReadLine();

            if (typeCargo == "fragile")
            {
                List<Car> fragileCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1)).ToList();

                foreach (var item in fragileCars)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                List<Car> flammableCars = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250).ToList();

                foreach (var item in flammableCars)
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }

}
