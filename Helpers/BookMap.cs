using bookapp.Models;
using CsvHelper.Configuration;

namespace BookApp.Helpers
{
    public class BookMap : ClassMap<Book>
    {
        public BookMap()
        {
            Map(b=>b.BookId).Index(0);
            Map(b=>b.Title).Index(1);
            Map(b=>b.Description).Index(2);
            Map(b=>b.PublishedOn).Index(3);
            Map(b=>b.ISBN).Index(4);
            Map(b=>b.Publisher).Index(5);
            Map(b=>b.Price).Index(6);
        }
    }
}