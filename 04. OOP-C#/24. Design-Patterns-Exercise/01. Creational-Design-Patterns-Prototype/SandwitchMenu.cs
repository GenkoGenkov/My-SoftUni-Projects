using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class SandwitchMenu
    {
        private readonly Dictionary<string, SandwichPrototype> sandwitches;

        public SandwitchMenu()
        {
            sandwitches = new Dictionary<string, SandwichPrototype>();
        }

        public SandwichPrototype this[string name]
        {
            get
            {
                return sandwitches[name];
            }
            set
            {
                sandwitches[name] = value;
            }
        } 
    }
}
