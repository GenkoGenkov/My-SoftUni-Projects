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
            Stack<string> stack = new Stack<string>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Push":
                        var elements = tokens.Skip(1).Select(i => i.Split(',').First()).ToArray();

                        stack.Push(elements);
                        break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
