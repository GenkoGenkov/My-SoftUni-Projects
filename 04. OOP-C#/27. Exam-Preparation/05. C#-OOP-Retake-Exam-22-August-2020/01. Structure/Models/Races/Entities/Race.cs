using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Models.Races.Entities
{
    public class Race : IRace
    {
        private const int MInLen = 5;
        private const int Minlaps = 1;

        private string name;
        private int laps;

        private readonly IDictionary<string, IDriver> driverByName;

        public Race(string name, int laps)
        {
            Name = name;
            Laps = laps;

            driverByName = new Dictionary<string, IDriver>();
        }

        public string Name 
        { 
            get => name;
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < MInLen)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, MInLen));
                }

                name = value;
            }
        }

        public int Laps 
        {
            get => laps;
            private set
            {
                if (value < Minlaps)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidNumberOfLaps, Minlaps));
                }

                laps = value;
            }
        }

        public IReadOnlyCollection<IDriver> Drivers => driverByName.Values.ToList();

        public void AddDriver(IDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(ExceptionMessages.DriverInvalid);
            }

            if (!driver.CanParticipate)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriverNotParticipate, driver.Name));
            }

            if (driverByName.ContainsKey(driver.Name))
            {
                throw new ArgumentNullException(string.Format(ExceptionMessages.DriverAlreadyAdded, driver.Name, Name));
            }

            driverByName.Add(driver.Name, driver);
        }
    }
}
