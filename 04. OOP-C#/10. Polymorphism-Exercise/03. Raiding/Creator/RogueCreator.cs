using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Creator
{
    public class RogueCreator : HeroCreator
    {
        private string _name;

        public RogueCreator(string name)
        {
            _name = name;
        }

        public override BaseHero GetHero()
            => new Rogue(_name);
    }
}
