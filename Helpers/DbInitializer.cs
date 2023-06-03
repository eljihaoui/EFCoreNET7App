using System.Globalization;
using bookapp.Models;
using CsvHelper;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Helpers
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;
        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            string[] tables = { "Book", "PriceOffer", "Author", "BookAuthor", "Review" };
            foreach (var tb in tables)
            {
                string filePath = @$"Data\{tb}.csv";
                using var reader = new StreamReader(filePath);
                using var csv = new CsvReader(reader, CultureInfo.CurrentCulture);
                switch (tb)
                {
                    case "Book":
                        csv.Context.RegisterClassMap<BookMap>();
                        modelBuilder.Entity<Book>().HasData(csv.GetRecords<Book>().ToArray());
                        break;
                    case "PriceOffer":
                        csv.Context.RegisterClassMap<PriceOfferMap>();
                        modelBuilder.Entity<PriceOffer>().HasData(csv.GetRecords<PriceOffer>().ToArray());
                        break;
                    case "Author":
                        csv.Context.RegisterClassMap<AuthorMap>();
                        modelBuilder.Entity<Author>().HasData(csv.GetRecords<Author>().ToArray());
                        break;
                    case "BookAuthor":
                        csv.Context.RegisterClassMap<BookAuthorMap>();
                        modelBuilder.Entity<BookAuthor>().HasData(csv.GetRecords<BookAuthor>().ToArray());
                        break;
                    case "Review":
                        csv.Context.RegisterClassMap<ReviewMap>();
                        modelBuilder.Entity<Review>().HasData(csv.GetRecords<Review>().ToArray());
                        break;
                    default: break;
                }
            }
        }
    }
}