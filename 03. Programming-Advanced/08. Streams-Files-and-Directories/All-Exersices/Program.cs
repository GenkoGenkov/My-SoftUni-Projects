using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void ZipAndExtract()
        {
            string sourceDirectory = @"C:\Users\Gi\Desktop\myFolder";
            string targetDirectory = @"C:\Users\Gi\Desktop\result123.zip";
            string destinationDirectory = @"C:\Users\Gi\Desktop\result123";

            ZipFile.CreateFromDirectory(sourceDirectory, targetDirectory);
            ZipFile.ExtractToDirectory(targetDirectory, destinationDirectory);
        }

        private static void DirectoryTraversal()
        {
            string[] allFiles = Directory.GetFiles(".");

            Dictionary<string, Dictionary<string, double>> groupedFiles = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in allFiles)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!groupedFiles.ContainsKey(fileInfo.Extension))
                {
                    groupedFiles.Add(fileInfo.Extension, new Dictionary<string, double>());
                }

                double size = (double)fileInfo.Length / 1024;

                groupedFiles[fileInfo.Extension].Add(fileInfo.Name, size);
            }

            var sortedFiles = groupedFiles.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            List<string> lines = new List<string>();

            foreach (var file in sortedFiles)
            {
                lines.Add(file.Key);

                foreach (var item in file.Value)
                {
                    lines.Add($"--{item.Key} - {item.Value:F3}kb");
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

            File.WriteAllLines(path, lines);
        }

        private static void CopyBinaryFile()
        {
            FileStream fileReader = new FileStream("copyMe.png", FileMode.Open);
            FileStream fileWriter = new FileStream("copyMeCopy.png", FileMode.Create);

            byte[] buffer = new byte[256];

            while (true)
            {
                int currentBytes = fileReader.Read(buffer, 0, buffer.Length);

                if (currentBytes == 0)
                {
                    fileWriter.Flush();
                    break;
                }

                fileWriter.Write(buffer, 0, buffer.Length);

            }
        }

        private static void WordCount()
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            string[] wordLines = File.ReadAllLines("words.txt");
            string[] textLines = File.ReadAllLines("text.txt");

            foreach (var item in wordLines)
            {
                if (!wordsCount.ContainsKey(item))
                {
                    wordsCount.Add(item, 0);
                }
            }

            foreach (var line in textLines)
            {
                foreach (var word in wordsCount)
                {
                    if (line.Contains(word.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        wordsCount[word.Key]++;
                    }
                }
            }

            foreach (var item in wordsCount.OrderByDescending(x => x.Value))
            {
                string result = $"{item.Key} - {item.Value}{Environment.NewLine}";

                File.AppendAllText("actualResult.txt", result);
            }
        }

        private static void LineNumbers()
        {
            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = lines[i].Count(symbol => char.IsLetter(symbol));
                int punctuationCount = lines[i].Count(symbol => char.IsPunctuation(symbol));

                File.AppendAllText("output.txt", $"Line {i + 1}:{lines[i]}({letterCount})({punctuationCount}){Environment.NewLine}");
            }
        }

        private static void EvenLines()
        {
            StreamReader streamreader = new StreamReader("text.txt");

            string[] specialSymbols = new[] { "-", ",", ".", "!", "?" };

            bool isEven = true;

            while (true)
            {
                string result = streamreader.ReadLine();

                if (result == null)
                {
                    break;
                }

                if (!isEven)
                {
                    isEven = true;
                    continue;
                }

                foreach (var symbol in specialSymbols)
                {
                    result = result.Replace(symbol, "@");
                }

                Console.WriteLine(string.Join(" ", result.Split().Reverse()));

                isEven = false;
            }
        }
    }
}
