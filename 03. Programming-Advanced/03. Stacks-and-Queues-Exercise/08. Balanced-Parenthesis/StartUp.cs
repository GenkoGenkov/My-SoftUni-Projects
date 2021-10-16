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
            string input = Console.ReadLine();

            Stack<char> parenthesis = new Stack<char>();

            bool isBakanced = true;

            foreach (var item in input)
            {
                if (item == '{' || item == '[' || item == '(')
                {
                    parenthesis.Push(item);
                }
                else
                {
                    if (parenthesis.Count == 0)
                    {
                        isBakanced = false;
                        break;
                    }

                    if (item == '}' && parenthesis.Peek() == '{')
                    {
                        parenthesis.Pop();
                    }
                    else if (item == ']' && parenthesis.Peek() == '[')
                    {
                        parenthesis.Pop();
                    }
                    else if (item == ')' && parenthesis.Peek() == '(')
                    {
                        parenthesis.Pop();
                    }
                    else
                    {
                        isBakanced = false;
                    }
                }
            }

            if (isBakanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
