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
            Stack<int> chlotes = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            int capacity = int.Parse(Console.ReadLine());

            int racksCounter = 1;
            int currentChlotes = 0;

            while (chlotes.Count > 0)
            {
                if (currentChlotes + chlotes.Peek() > capacity)
                {
                    currentChlotes = 0;
                    racksCounter++;
                }

                currentChlotes += chlotes.Pop();
            }

            Console.WriteLine(racksCounter);
        }
    }
}
