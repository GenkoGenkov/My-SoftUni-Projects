using ConsoleApp1;
using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            ListyIterator<string> listy = null;

            while (command != "END")
            {
                string[] data = command.Split();

                if (data[0] == "Create")
                {
                    listy = new ListyIterator<string>(data.Skip(1).ToArray());
                }
                else if (data[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (data[0] == "Print")
                {
                    listy.Print();
                }
                else if (data[0] == "PrintAll")
                {
                    listy.PrintAll();
                }
                else if (data[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                
                command = Console.ReadLine();
            }
        }
    }
}
