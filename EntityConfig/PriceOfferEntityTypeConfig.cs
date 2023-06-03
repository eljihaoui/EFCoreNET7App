

using bookapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.EntityConfig
{
    public class PriceOfferEntityTypeConfig : IEntityTypeConfiguration<PriceOffer>
    {
        public void Configure(EntityTypeBuilder<PriceOffer> builder)
        {
            builder.HasKey(p=>p.PriceOfferId);
            builder.Property(p=>p.NewPrice).IsRequired();

            // configure on too one relationship between Book and PriceOffer
            builder.HasOne<Book>(p=>p.Book)
            .WithOne(b=>b.PriceOffer)
            .HasForeignKey<PriceOffer>(b=>b.BookId);
        }
    }
}