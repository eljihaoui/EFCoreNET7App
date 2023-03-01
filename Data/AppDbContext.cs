using EFCoreNET7App.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreNET7App.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=EFCoreDb;Trusted_Connection=True;Encrypt=False;");
        }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Category>? Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
             new Category {Id=1, Name = "Web" },
             new Category {Id=2, Name = "Development" },
             new Category {Id=3, Name = "Design" },
             new Category {Id=4, Name = "Marketing" }
            );
        }
    }
}