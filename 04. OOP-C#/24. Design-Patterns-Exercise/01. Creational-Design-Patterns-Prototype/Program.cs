using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SandwitchMenu sandwitchMenu = new SandwitchMenu();

            sandwitchMenu["BLT"] = new Sandwitch("Wheat", "Chicken", "Fetta", "Lettuce");
            sandwitchMenu["Bigmac"] = new Sandwitch("Wheat", "Pork", "", "Lettuce, Tomato, Cucumber");

            Sandwitch sandwitch = sandwitchMenu["BLT"].ShallowCopy() as Sandwitch;
        }
    }
}
