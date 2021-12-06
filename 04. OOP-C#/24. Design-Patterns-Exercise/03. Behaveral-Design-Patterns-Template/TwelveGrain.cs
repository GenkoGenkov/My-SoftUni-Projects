using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class TwelveGrain : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Bake for 25 minutes");
        }

        public override void MixIngridients()
        {
            Console.WriteLine("Get 12 grains");
        }
    }
}
