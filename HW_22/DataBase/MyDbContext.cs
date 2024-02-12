
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

        public string DbPath { get; }

        public AppDbContext()
        {
            DbPath = System.IO.Path.Join(@"D:\DB_Test", "SqLiteTest.db");
          
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}
