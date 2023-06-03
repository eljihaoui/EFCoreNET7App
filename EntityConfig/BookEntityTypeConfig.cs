using bookapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.EntityConfig
{
    public class BookEntityTypeConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            builder.Property(b => b.Title).IsRequired();
            builder.Property(b => b.Price).IsRequired();
            builder.HasIndex(b => b.Title).HasDatabaseName("Index_BookTitle");
            builder.HasIndex(b => b.ISBN).IsUnique().HasDatabaseName("Unique_ISBN_Index");
           
        }
    }
}