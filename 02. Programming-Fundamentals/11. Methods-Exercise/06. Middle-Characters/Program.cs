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
            string inputText = Console.ReadLine();

            string result = GetMiddlecharacters(inputText);

            Console.WriteLine(result);
        }

        private static string GetMiddlecharacters(string inputText)
        {
            string result = string.Empty;

            if (inputText.Length % 2 == 1)
            {
                result = inputText[inputText.Length / 2].ToString();
            }
            else
            {

                result = inputText[inputText.Length / 2 - 1].ToString() + inputText[inputText.Length / 2].ToString();
            }

            return result;
        }
    }
}

