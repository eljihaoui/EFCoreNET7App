using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.EntityConfig
{
    public class BookAuthorEntityTypeConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(ba=>new {ba.BookId,ba.AuthorId});
            builder.Property(ba=>ba.Order).IsRequired();

            // Configure relationship Book <=> BookAuthor
             builder.HasOne<Book>(ba=>ba.Book)
            .WithMany(b=>b.BookAuthors)
            .HasForeignKey(ba=>ba.BookId);

            // Configure relationship Author <=> BookAuthor
             builder.HasOne<Author>(ba=>ba.Author)
            .WithMany(b=>b.BookAuthors)
            .HasForeignKey(ba=>ba.AuthorId);

        }
    }
}