using System.ComponentModel.DataAnnotations;
namespace SampleMVC.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string? AuthorName { get; set; }
        public string? City { get; set; }
        ICollection<Book>? Books { get; set; }
    }
}
