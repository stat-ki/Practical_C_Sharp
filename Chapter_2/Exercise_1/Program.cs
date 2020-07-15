using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new Song[]
            {
                new Song("Let it be", "The Beatles", 243),
                new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
                new Song("Close To You", "Carpenters", 276),
                new Song("Honesty", "Billy Joel", 231),
                new Song("I Will Always Love You", "Whitney Houston", 273),
            };
            PrintSongList(songs);
        }

        private static void PrintSongList(Song[] songs)
        {
            foreach (var song in songs)
            {
                Console.WriteLine(@"{0}, {1}, {2:m\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
