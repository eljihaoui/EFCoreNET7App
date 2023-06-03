using bookapp.Models;
using CsvHelper.Configuration;

namespace BookApp.Helpers
{
public class PriceOfferMap : ClassMap<PriceOffer>
    {
        public PriceOfferMap()
        {
            Map(p=>p.PriceOfferId).Index(0);
            Map(p=>p.NewPrice).Index(1);
            Map(p=>p.OfferText).Index(2);
            Map(p=>p.BookId).Index(3);
        }
    }
}