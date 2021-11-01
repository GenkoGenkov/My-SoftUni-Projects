using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var lake = new Lake(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
