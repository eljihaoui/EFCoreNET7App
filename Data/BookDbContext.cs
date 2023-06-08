
using System.Reflection;
using bookapp.Models;
using BookApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace bookapp.Data
{
    public class BookDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BookApp;Trusted_Connection=True;Encrypt=False;");
            string mySqlcon ="Server=localhost;Database=BookApp;User=root;Password=Med@2023;";
            MySqlServerVersion mysqlVersion = new(new Version(8, 0, 33));
            optionsBuilder.UseMySql(mySqlcon,mysqlVersion);
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