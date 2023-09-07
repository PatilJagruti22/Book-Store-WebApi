using BookCart.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCart.Models
{
    [Table(name: "Books")]
    public class BookCart
    {
        [Key]
        public Guid BookId { get; set; }
        [Required]
        public string? Title { get; set; }
        public int TotalPages { get; set; }
        public Price? Price { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedOn { get; set; }
        public List<Author>? Authors { get; set; }
    }
}