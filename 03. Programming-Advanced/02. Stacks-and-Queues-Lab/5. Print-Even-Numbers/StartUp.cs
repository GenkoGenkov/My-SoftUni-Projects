using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Queue<int> sequence = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i]) % 2 == 0)
                {
                    sequence.Enqueue(int.Parse(input[i]));
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
