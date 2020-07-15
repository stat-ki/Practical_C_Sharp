using System;

namespace Exercise_1
{
    class Song
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        public Song(string title, string artistname, int length)
        {
            Title = title;
            ArtistName = artistname;
            Length = length;
        }
    }
}
