using EFCoreNET7App.Data;
using EFCoreNET7App.Models;
using static System.Console;
AppDbContext db = new();
if (db != null)
{
    Book b = new() { Name = "CSharp", Description = "Programming with C#" };
    db.Add<Book>(b); // or  db.Add(b)
    bool res = (await db.SaveChangesAsync()) > 0;
    if(res){
        WriteLine("Book Inserted successfully");
    }else{
        WriteLine("Book not Inserted successfully");
    }
}
// Book b = new() { Name = "CSharp", Description = "Programming with C#" };
// if (db != null)
// {
//     db.Books?.Add(b);
//     bool res = (await db.SaveChangesAsync()) > 0;
//     if(res){
//         WriteLine("Book Inserted successfully");
//     }else{
//         WriteLine("Book not Inserted successfully");
//     }
// }
