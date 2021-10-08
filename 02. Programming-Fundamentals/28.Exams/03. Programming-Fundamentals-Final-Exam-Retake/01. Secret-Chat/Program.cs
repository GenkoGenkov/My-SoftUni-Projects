using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());

            string[] command = Console.ReadLine().Split(":|:");

            while (command[0] != "Reveal")
            {


                switch (command[0])
                {
                    case "InsertSpace":

                        message.Insert(int.Parse(command[1]), ' ');

                        Console.WriteLine(message);
                        break;

                    case "Reverse":

                        string substring = command[1];
                        int index = message.ToString().IndexOf(substring);

                        if (!message.ToString().Contains(substring))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {

                            substring = string.Join("", substring.ToCharArray().Reverse());
                            message.Remove(index, substring.Length);
                            message.Append(substring);

                            Console.WriteLine(message);
                        }

                        break;

                    case "ChangeAll":

                        string substringTwo = command[1];
                        string replacement = command[2];

                        if (message.ToString().Contains(substringTwo))
                        {
                            message.Replace(substringTwo, replacement);
                        }

                        Console.WriteLine(message);
                        break;
                }

                command = Console.ReadLine().Split(":|:");
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}

