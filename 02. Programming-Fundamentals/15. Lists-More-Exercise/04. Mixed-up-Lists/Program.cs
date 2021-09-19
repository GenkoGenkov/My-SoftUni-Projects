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
            List<int> firstLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondLine = Console.ReadLine().Split().Select(int.Parse).ToList();

            int smallestLine = Math.Min(firstLine.Count, secondLine.Count);

            List<int> combinedList = new List<int>(smallestLine);

            secondLine.Reverse();

            for (int i = 0; i < smallestLine; i++)
            {
                combinedList.Add(firstLine[i]);
                combinedList.Add(secondLine[i]);
            }

            int constraintOne = 0;
            int constraintTwo = 0;

            if (firstLine.Count > secondLine.Count)
            {
                constraintOne = firstLine[firstLine.Count - 1];
                constraintTwo = firstLine[firstLine.Count - 2];
            }
            else
            {
                constraintOne = secondLine[secondLine.Count - 1];
                constraintTwo = secondLine[secondLine.Count - 2];
            }

            int smallerConstraintNum = Math.Min(constraintTwo, constraintOne);
            int biggerConstraintNum = Math.Max(constraintTwo, constraintOne);

            List<int> listToPrint = new List<int>();

            listToPrint = combinedList.Where(n => n > smallerConstraintNum && n < biggerConstraintNum).ToList();

            listToPrint.Sort();

            Console.WriteLine(string.Join(" ", listToPrint));
        }
    }
}

