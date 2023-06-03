
using System.Reflection;
using bookapp.Models;
using BookApp.EntityConfig;
using BookApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace bookapp.Data
{
    public class BookDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BookApp;Trusted_Connection=True;Encrypt=False;");
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }
        public DbSet<PriceOffer> PriceOffer { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new BookEntityTypeConfig());
            // modelBuilder.ApplyConfiguration(new PriceOfferEntityTypeConfig());
            // modelBuilder.ApplyConfiguration(new ReviewEntityTypeConfig());
            // modelBuilder.ApplyConfiguration(new AuthorEntityTypeConfig());
            // modelBuilder.ApplyConfiguration(new BookAuthorEntityTypeConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            new DbInitializer(modelBuilder).Seed();
        }
    }
}