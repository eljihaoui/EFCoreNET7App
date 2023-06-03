using bookapp.Models;
using CsvHelper.Configuration;

namespace BookApp.Helpers
{
    public class BookAuthorMap : ClassMap<BookAuthor>
    {
        public BookAuthorMap()
        {
            Map(ba=>ba.BookId).Index(0);
            Map(ba=>ba.AuthorId).Index(1);
            Map(ba=>ba.Order).Index(2);        
            
        }
    }

}