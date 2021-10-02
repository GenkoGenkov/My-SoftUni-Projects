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
            int key = int.Parse(Console.ReadLine());

            string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behaviour>[GN])!";

            List<string> goodChildren = new List<string>();

            string childData = Console.ReadLine();

            while (childData != "end")
            {
                char[] child = childData.ToCharArray();

                for (int i = 0; i < childData.Length; i++)
                {
                    child[i] = (char)(child[i] - key);
                }

                childData = string.Join("", child);

                Match childMatch = Regex.Match(childData, pattern);

                string name = childMatch.Groups["name"].Value;
                string behaviour = childMatch.Groups["behaviour"].Value;

                if (behaviour == "G")
                {
                    goodChildren.Add(name);
                }

                childData = Console.ReadLine();
            }

            foreach (var item in goodChildren)
            {
                Console.WriteLine(item);
            }
        }
    }
}