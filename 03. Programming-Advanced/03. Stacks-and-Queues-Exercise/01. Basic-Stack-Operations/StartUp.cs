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

            Stack<int> work = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            for (int i = 0; i < commands[1]; i++)
            {
                work.Pop();
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
