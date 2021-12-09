﻿using Easter.Models.Eggs.Contracts;
using Easter.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Eggs
{
    public class Egg : IEgg
    {
        private string name;
        private int energyRequired;

        public string Name 
        { 
            get => name;
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEggName);
                }

                name = value;
            }
        }

        public int EnergyRequired 
        { 
            get => energyRequired;
            private set 
            {
                energyRequired = value;

                if (energyRequired < 0)
                {
                    energyRequired = 0;
                }
            }
        }

        public void GetColored()
        {
            EnergyRequired -= 10;
        }

        public bool IsDone() => EnergyRequired == 0;
    }
}
