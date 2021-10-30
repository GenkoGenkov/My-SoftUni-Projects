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
            string street = nameTownInput[2];
            string town = string.Join(" ", nameTownInput.Skip(3));

            string[] nameBeerInput = Console.ReadLine().Split();
            string name = nameBeerInput[0];
            int litres = int.Parse(nameBeerInput[1]);
            bool isDrunk = nameBeerInput[2] == "drunk";

            string[] numbersInput = Console.ReadLine().Split();
            string numberName = numbersInput[0];
            double doubleNumber = double.Parse(numbersInput[1]);
            string bankName = numbersInput[2];

            Threeuple<string, string, string> nameTown = new Threeuple<string, string, string>(nameOne, street, town);
            Threeuple<string, int, bool> nameBeer = new Threeuple<string, int, bool>(name, litres, isDrunk);
            Threeuple<string, double, string> numbers = new Threeuple<string, double, string>(numberName, doubleNumber, bankName);

            Console.WriteLine(nameTown.GetItems());
            Console.WriteLine(nameBeer.GetItems());
            Console.WriteLine(numbers.GetItems());
        }
    }
}
