using bookapp.Models;
using CsvHelper.Configuration;

namespace BookApp.Helpers
{
    public class ReviewMap : ClassMap<Review>
    {
        public ReviewMap()
        {
            Map(r => r.ReviewId).Index(0);
            Map(r => r.VoterName).Index(1);
            Map(r => r.Rating).Index(2);
            Map(r => r.Comment).Index(3);
            Map(r => r.BookId).Index(4);
        }
    }
}