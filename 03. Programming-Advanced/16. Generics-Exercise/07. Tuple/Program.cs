using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using ConsoleApp2;

namespace ConsoleApp11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] nameTownInput = Console.ReadLine().Split();
            string nameOne = $"{nameTownInput[0]} {nameTownInput[1]}";
            string town = nameTownInput[2];

            string[] nameBeerInput = Console.ReadLine().Split();
            string name = nameBeerInput[0];
            int litres = int.Parse(nameBeerInput[1]);

            string[] numbersInput = Console.ReadLine().Split();
            int integer = int.Parse(numbersInput[0]);
            double doubleNumber = double.Parse(numbersInput[1]);

            MyTuple<string, string> nameTown = new MyTuple<string, string>(nameOne, town);
            MyTuple<string, int> nameBeer = new MyTuple<string, int>(name, litres);
            MyTuple<int, double> numbers = new MyTuple<int, double>(integer, doubleNumber);

            Console.WriteLine(nameTown.GetItems());
            Console.WriteLine(nameBeer.GetItems());
            Console.WriteLine(numbers.GetItems());
        }
    }
}
