using System;

namespace Exercise_1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublshedYear { get; set; }
        public virtual Author Author { get; set; }
    }
}