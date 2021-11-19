using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in phoneNumbers)
            {
                if (!item.All(c => char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                ICallable currPhone = null;

                if (item.Length == 7)
                {
                    currPhone = new StationaryPhone();
                }
                else if (item.Length == 10)
                {
                    currPhone = new Smartphone();
                }

                currPhone.Call(item);
            }

            foreach (var url in urls)
            {
                if (url.Any(c => char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }

                Smartphone currSmartphone = new Smartphone();
                currSmartphone.Browse(url);
            }
        }
    }
}


