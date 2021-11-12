using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentSystem studentSystem = new StudentSystem();

            while (true)
            {
                studentSystem.ParseCommand();
            }
        }
    }
}