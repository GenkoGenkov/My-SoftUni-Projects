using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IDrivable
    {
        double FuelQuantity { get; }
        double FuelConsumptionPerKm { get; }
        void Drive(double distance);
        void Refuel(double amountFuel);

    }
}
