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
            string input = Console.ReadLine();

            MatchCollection equals = Regex.Matches(input, @"\+[3][5][9](?<separator>\-|\ )[2]\k<separator>[0-9]{3}\k<separator>[0-9]{4}\b");

            Console.WriteLine(string.Join(", ", equals));
        }
    }
}