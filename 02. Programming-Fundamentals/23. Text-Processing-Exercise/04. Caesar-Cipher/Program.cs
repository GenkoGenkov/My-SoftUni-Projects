using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Console.ReadLine();

            int lastIndexOfLeftPipe = fullPath.LastIndexOf('\\');

            string fileNameWithExtention = fullPath.Substring(lastIndexOfLeftPipe + 1, fullPath.Length - lastIndexOfLeftPipe - 1);

            int extentionIndex = fileNameWithExtention.LastIndexOf('.');

            string extension = fileNameWithExtention.Substring(extentionIndex + 1, fileNameWithExtention.Length - extentionIndex - 1);

            string name = fileNameWithExtention.Substring(0, extentionIndex);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }  
    }
}
