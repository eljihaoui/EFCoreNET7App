
namespace bookapp.Models
{
    public class PriceOffer
    {
        public int PriceOfferId { get; set; }
        public float NewPrice { get; set; }
        public string OfferText { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}