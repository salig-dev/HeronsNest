using HeronsNest.Models;
using Microsoft.EntityFrameworkCore;

namespace HeronsNest.Context
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=BookInformation.db");
    }
}
