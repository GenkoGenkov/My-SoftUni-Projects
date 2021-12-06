using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class WholeWheat : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Bake for 15 minutes");
        }

        public override void MixIngridients()
        {
            Console.WriteLine("Whole wheat bread");
        }
    }
}
