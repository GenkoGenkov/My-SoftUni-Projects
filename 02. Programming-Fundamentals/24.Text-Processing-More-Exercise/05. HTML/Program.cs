using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder html = new StringBuilder();

            string title = Console.ReadLine();
            string article = Console.ReadLine();
            string comments = Console.ReadLine();


            html.Append($"<h1>\n   {title}\n</h1>\n");
            html.Append($"<article>\n   {article}\n</article>\n");

            while (comments != "end of comments")
            {
                html.Append($"<div>\n   {comments}\n</div>\n");

                comments = Console.ReadLine();
            }

            Console.WriteLine(html);
        }
    }
}