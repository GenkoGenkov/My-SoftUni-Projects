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
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, PianoPeace> collection = new Dictionary<string, PianoPeace>();

            for (int i = 0; i < n; i++)
            {
                string[] piecesData = Console.ReadLine().Split("|");

                string piece = piecesData[0];
                string composer = piecesData[1];
                string key = piecesData[2];

                PianoPeace currentPianoPiece = new PianoPeace(composer, key);

                collection.Add(piece, currentPianoPiece);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] dataActions = command.Split("|");

                string action = dataActions[0];

                if (action == "Add")
                {
                    string pieceName = dataActions[1];
                    string composerName = dataActions[2];
                    string keyName = dataActions[3];

                    if (!collection.ContainsKey(pieceName))
                    {
                        collection.Add(pieceName, new PianoPeace(composerName, keyName));

                        Console.WriteLine($"{pieceName} by {composerName} in {keyName} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }

                }
                else if (action == "Remove")
                {
                    string pieceName = dataActions[1];

                    if (collection.ContainsKey(pieceName))
                    {
                        collection.Remove(pieceName);

                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    string pieceName = dataActions[1];
                    string keyName = dataActions[2];

                    if (collection.ContainsKey(pieceName))
                    {
                        collection[pieceName].Key = keyName;

                        Console.WriteLine($"Changed the key of {pieceName} to {keyName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }


                command = Console.ReadLine();
            }

            foreach (var item in collection.OrderBy(i => i.Key).ThenBy(i => i.Value.Composer))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
            }

        }
    }

    class PianoPeace
    {
        public PianoPeace(string composer, string key)
        {
            Composer = composer;
            Key = key;
        }

        public string Composer { get; set; }
        public string Key { get; set; }
    }
}

