using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleMVC.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string? Title { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public int Price { get; set; }
        public Author? Authors { get; set; }
    }
}
