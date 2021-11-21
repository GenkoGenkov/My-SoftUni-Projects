using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Creator
{
    public class DruidCreator : HeroCreator
    {
        private string _name;

        public DruidCreator(string name)
        {
            _name = name;
        }

        public override BaseHero GetHero()
            => new Druid(_name);
    }
}
