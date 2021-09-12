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
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int aplicationMaxSequence = 0;
            int maxSequence = 0;
            int currentSequence = 0;
            int mostLeftIndex = int.MaxValue;
            string element = string.Empty;
            int bestDna = 1;
            int currentDna = 0;
            int maxSum = 0;
            int[] result = null;


            while (command != "Clone them!")
            {
                currentDna++;

                int[] numbers = command.Split('!').Select(int.Parse).ToArray();

                int sum = 0;
                currentSequence = 0;
                maxSequence = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        currentSequence = 0;
                        continue;
                    }

                    sum++;
                    currentSequence++;



                    if (currentSequence >= maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }

                string targetString = new string('1', maxSequence);
                int currentIndex = string.Join("", numbers).IndexOf(targetString);

                if (maxSequence >= aplicationMaxSequence && currentIndex < mostLeftIndex || maxSequence == aplicationMaxSequence && currentIndex == mostLeftIndex && sum > maxSum)
                {
                    aplicationMaxSequence = maxSequence;
                    mostLeftIndex = currentIndex;
                    maxSum = sum;
                    bestDna = currentDna;
                    result = numbers;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDna} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

