using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());

            int row = 1;
            int currNum = 1;
            bool isEqual = false;

            while (isEqual == false)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(currNum + " ");
                    currNum++;

                    if (currNum > targetNum)
                    {
                        isEqual = true;
                        break;
                    }
                }

                Console.WriteLine();
                row++;
            }
        }
    }
}

