using bookapp.Data;

using var context = new BookDbContext();
var book = context.Book.SingleOrDefault(b=>b.BookId==100); 

Console.WriteLine(book==null ? "not found ":$"Title : {book.Title} => Price : {book.Price}");


