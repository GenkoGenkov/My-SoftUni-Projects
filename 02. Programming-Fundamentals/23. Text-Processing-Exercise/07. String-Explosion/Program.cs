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

            StringBuilder sb = new StringBuilder(input);
            int counter = 0;
            int reminder = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int power = int.Parse(input[i + 1].ToString()) + reminder;
                    int leftPower = power;
                    bool shouldReset = true;

                    for (int j = i + 1; j < i + 1 + power && j < input.Length; j++)
                    {
                        if (input[j] == '>')
                        {
                            reminder = leftPower;
                            shouldReset = false;
                            break;
                        }

                        sb.Remove(j - counter, 1);
                        leftPower--;
                        counter++;
                    }

                    if (shouldReset)
                    {
                        reminder = 0;
                    }


                }
            }

            Console.WriteLine(sb);
        }  
    }
}
