
using bookapp.Models;
using CsvHelper.Configuration;

namespace BookApp.Helpers
{
  public class AuthorMap : ClassMap<Author>
    {
        public AuthorMap()
        {
            Map(a=>a.AuthorId).Index(0);
            Map(a=>a.FirstName).Index(1);
            Map(a=>a.LastName).Index(2);
        }
    }

}