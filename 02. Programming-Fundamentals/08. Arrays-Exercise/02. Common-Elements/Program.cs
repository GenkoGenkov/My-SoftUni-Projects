using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            for (int i = 0; i < secondArray.Length; i++)
            {
                string currentElement = secondArray[i];

                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (currentElement == firstArray[j])
                    {
                        Console.Write(currentElement + " ");
                    }
                }
            }
        }
    }
}

