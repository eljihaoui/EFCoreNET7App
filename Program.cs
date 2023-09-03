using bookapp.Data;
using static System.Console;
// OrderBy
using var _context = new BookDbContext();
var books = _context.Book.OrderByDescending(b=>b.PublishedOn).ThenByDescending(b=>b.Price);
foreach (var book in books)
{
    WriteLine($"- Year : {book.PublishedOn}  Price : {book.Price} Title : {book.Title} ");
}
