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
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1 } by zero");
                    }
                    else
                    {
                        result = num1 * 1.0 / num2;
                    }

                    break;
                case '%':
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1 } by zero");
                    }
                    else
                    {
                        result = num1 % num2;
                    }

                    break;
                default:
                    break;
            }

            if (operation == '+' || operation == '-' || operation == '*')
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
                }

            }
            else if (operation == '/' && num2 != 0)
            {
                Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
            }
            else if (operation == '%' && num2 != 0)
            {
                Console.WriteLine($"{num1} {operation} {num2} = {result}");
            }
        }
    }
}
