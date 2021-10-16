using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> work = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            for (int i = 0; i < commands[1]; i++)
            {
                work.Dequeue();
            }

            if (work.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else if (work.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else if (!work.Contains(commands[2]))
            {
                Console.WriteLine(work.Min());
            }
        }
    }
}
