
using System.ComponentModel.DataAnnotations;
namespace EFCoreNET7App.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}