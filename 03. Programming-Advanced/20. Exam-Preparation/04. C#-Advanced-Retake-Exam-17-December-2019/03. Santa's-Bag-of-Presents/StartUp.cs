using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace Christmas
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Present one = new Present("Doll", 100, "girl");
            Present two = new Present("Truck", 200, "boy");

            Bag blueBag = new Bag("blue", 5);

            blueBag.Add(one);
            blueBag.Add(two);
            

            Console.WriteLine(blueBag.GetPresent("Truck").ToString());            
        }
    }
}

