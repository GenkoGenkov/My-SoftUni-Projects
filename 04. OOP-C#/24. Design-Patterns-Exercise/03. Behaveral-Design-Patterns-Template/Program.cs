using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bread wholeWheat = new WholeWheat();
            Bread twelveGrain = new TwelveGrain();

            wholeWheat.Make();
            twelveGrain.Make();
        }
    }
}
