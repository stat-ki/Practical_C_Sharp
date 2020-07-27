namespace Exercise_1.Models
{
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Linq;
    using Exercise_1.Models;

    public class BooksDbContext : DbContext
    {
        public BooksDbContext()
            : base("name=BooksDbContext")
        {
            Database.SetInitializer(
               new MigrateDatabaseToLatestVersion<BooksDbContext, Configuration>());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}