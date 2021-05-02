using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSong = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numSong; i++)
            {
                string[] arrArg = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries);

                string type = arrArg[0];
                string name = arrArg[1];
                string time = arrArg[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
            //List<Song> filteredSongs = songs
            //        .Where(s => s.TypeList == typeList)
            //        .ToList();

            //foreach (Song song in filteredSongs)
            //{
            //    Console.WriteLine(song.Name);
            //}
        }
    }
}
