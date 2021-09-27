using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multyplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int reminder = 0;

            if (input == "0" || multyplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(input[i].ToString());

                int product = currentDigit * multyplier + reminder;

                int result = product % 10;

                reminder = product / 10;

                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }

            Console.WriteLine(sb);
        }  
    }
}
