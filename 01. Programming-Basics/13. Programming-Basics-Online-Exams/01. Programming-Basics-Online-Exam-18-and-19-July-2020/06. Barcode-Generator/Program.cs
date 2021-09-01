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
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int fdOne = firstNumber / 1000;
            int fdTwo = firstNumber / 100 % 10;
            int fdThree = firstNumber / 10 % 10;
            int fdFour = firstNumber % 10;
            int sdOne = secondNumber / 1000;
            int sdTwo = secondNumber / 100 % 10;
            int sdThree = secondNumber / 10 % 10;
            int sdFour = secondNumber % 10;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if ((a % 2 != 0) && a >= fdOne && a <= sdOne)
                            {
                                if ((b % 2 != 0) && b >= fdTwo && b <= sdTwo)
                                {
                                    if ((c % 2 != 0) && c >= fdThree && c <= sdThree)
                                    {
                                        if ((d % 2 != 0) && d >= fdFour && d <= sdFour)
                                        {
                                            Console.Write("" + a + b + c + d + " ");
                                        }
                                    }
                                }
                            }

                        }
                    }
                }

            }
        }
    }
}

