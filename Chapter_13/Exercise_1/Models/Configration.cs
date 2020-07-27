using System;
using System.Data.Entity.Migrations;

namespace Exercise_1.Models
{
    internal sealed class Configuration :
                            DbMigrationsConfiguration<BooksDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Exercise1.Models.BooksDbContext";
        }
    }
}