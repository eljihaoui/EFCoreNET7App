using bookapp.Data;
using bookapp.Models;

namespace BookApp.Helpers
{
    public static class DataSeeding
    {
        public  static void Seed()
        {
            using var context = new BookDbContext();
            context.Database.EnsureCreated();
            // context.AddRange(
            //     new Book { Title = "C# Pro", Description = "Programming C#", ISBN = "111-4", Price = 120, Publisher = "Manning", PublishedOn = DateTime.Parse("2022-01-02") },
            //     new Book { Title = "Java", Description = "Programming With Java", ISBN = "111-5", Price = 150, Publisher = "Appress", PublishedOn = DateTime.Parse("2021-07-06") }
            // );
            context.SaveChanges();
            Console.WriteLine("Call Seed function from DataSeeding Class");
        }
    }
}