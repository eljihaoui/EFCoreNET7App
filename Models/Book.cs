using Microsoft.EntityFrameworkCore;

namespace bookapp.Models
{
    
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PublishedOn {get;set ;}
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public float Price { get; set; }

        public PriceOffer PriceOffer { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}