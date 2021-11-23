﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            byte result;

            firstNumber = 30;
            secondNumber = 60;

            try
            {
                result = Convert.ToByte(firstNumber * secondNumber);

                Console.WriteLine($"{firstNumber} x {secondNumber} = {result}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
