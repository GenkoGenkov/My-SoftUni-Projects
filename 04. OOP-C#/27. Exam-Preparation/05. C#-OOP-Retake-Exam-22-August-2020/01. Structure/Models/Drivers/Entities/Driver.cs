﻿using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        private const int ModelMInLen = 5;

        private string name;

        public Driver(string name)
        {
            Name = name;
        }

        public string Name 
        { 
            get => name;
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < ModelMInLen)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, ModelMInLen));
                }

                name = value;
            }
        }

        public ICar Car { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate => Car != null;

        public void AddCar(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CarInvalid);
            }

            this.Car = car;
        }

        public void WinRace()
        {
            NumberOfWins += 1;
        }
    }
}
