using bookapp.Data;
using static System.Console;
// All  and Any 
using var _context = new BookDbContext();
var IsEmpty = _context.Book.Any(b=>b.Title.StartsWith("D"));
// SELECT CASE
//     WHEN EXISTS (
//         SELECT 1
//         FROM [Book] AS [b]
//         WHERE [b].[Title] LIKE N'D%') THEN CAST(1 AS bit)
//     ELSE CAST(0 AS bit)
// END
WriteLine($"IsEmpty : {IsEmpty}");

var isIdAllSup0 = _context.Book.All(b=>b.BookId>0);
// SELECT CASE
//     WHEN NOT EXISTS (
//         SELECT 1
//         FROM [Book] AS [b]
//         WHERE [b].[BookId] <= 0) THEN CAST(1 AS bit)
//     ELSE CAST(0 AS bit)
// END
WriteLine($"isIdAllSup0 : {isIdAllSup0}");



// int [] list = {1,2,3,4,-6,-7,8,9,3} ;
// bool IsPositive = list.All(v=>v>0);
// bool IsContainsNegative = list.Any(v=>v>0);
// WriteLine($"IsPositive : {IsPositive}");
// WriteLine($"IsContainsNegative : {IsContainsNegative}");

// List<string> lists = new() { "mohamed", "majid", "marim" };
// bool result = lists.All(str=>str.StartsWith("m"));
// WriteLine($"Start with M : {result}");
