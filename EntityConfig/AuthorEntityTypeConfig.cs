using bookapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.EntityConfig
{
    public class AuthorEntityTypeConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a=>a.AuthorId);
            builder.Property(a=>a.FirstName).IsRequired();
            builder.Property(a=>a.LastName).IsRequired();
            builder.HasIndex(a=> new {a.FirstName,a.LastName}).HasDatabaseName("Index_FullName");

        }
    }
}