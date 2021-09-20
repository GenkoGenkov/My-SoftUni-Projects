using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> allSongs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split('_');
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                allSongs.Add(song);
            }

            string secondTypeList = Console.ReadLine();

            if (secondTypeList == "all")
            {
                foreach (Song song in allSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in allSongs)
                {
                    if (song.TypeList == secondTypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
