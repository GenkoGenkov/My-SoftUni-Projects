using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var currentUser in input)
            {
                if (currentUser.Length < 3 || currentUser.Length > 16)
                {
                    continue;
                }

                bool isValid = false;

                foreach (var symbol in currentUser)
                {
                    if (!(char.IsDigit(symbol) || char.IsLetter(symbol) || symbol == '-' || symbol == '_'))
                    {
                        isValid = false;
                        break;
                    }

                    isValid = true;
                }

                if (isValid)
                {
                    Console.WriteLine(currentUser);
                }
            }
        }  
    }
}
