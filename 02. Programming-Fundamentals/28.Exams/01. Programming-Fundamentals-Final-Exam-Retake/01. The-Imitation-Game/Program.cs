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

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] data = command.Split("|");

                string action = data[0];

                if (action == "Move")
                {
                    string moves = data[1];

                    string deleted = message.ToString().Substring(0, int.Parse(moves));
                    message = message.Remove(0, int.Parse(moves));
                    message.Append(deleted);

                }
                else if (action == "Insert")
                {
                    int position = int.Parse(data[1]);
                    string word = data[2];

                    message.Insert(position, word);
                }
                else if (action == "ChangeAll")
                {
                    string word = data[1];
                    string replacement = data[2];

                    message.Replace(word, replacement);
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}