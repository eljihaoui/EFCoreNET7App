using bookapp.Data;
using bookapp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static System.Console;
// Add and AddRange
using var _context = new BookDbContext();
Author author = new() { FirstName = "Kamal", LastName = "hami" };
// _context.Author.Add(author); // added to memory 
// int res =_context.SaveChanges();//  sychnonized to database ( si >0 oui : non)
List<Author> listAuth = new()
{
    new (){FirstName="First Auth4", LastName="Last Auth4"},
    new (){FirstName="First Auth5", LastName="Last Auth5"},
    new (){FirstName="First Auth6", LastName="Last Auth6"}
};
// _context.Author.AddRange(listAuth);
// _context.SaveChanges();

Book book = new()
{
    Title = "Book test",
    Description = "test description ",
    PublishedOn = 2023,
    ISBN = "113-444000",
    Publisher = "Publisher 2023",
    Price = 120,
    PriceOffer = new PriceOffer()
    {
        NewPrice = 80,
        OfferText="Promo 2023"
    }
};
_context.Book.Add(book);
_context.SaveChanges();
