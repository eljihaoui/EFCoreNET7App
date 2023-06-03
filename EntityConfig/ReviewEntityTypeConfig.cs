using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.EntityConfig
{
    public class ReviewEntityTypeConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r=>r.ReviewId);
            builder.Property(r=>r.VoterName).IsRequired();
            builder.Property(r=>r.Rating).IsRequired();
            builder.HasIndex(r=>r.VoterName).HasDatabaseName("Index_VoterName");

            // configure one to many raltionship Book <=> Review
            builder.HasOne<Book>(r=>r.Book)
            .WithMany(b=>b.Reviews)
            .HasForeignKey(r=>r.BookId);

        }
    }
}