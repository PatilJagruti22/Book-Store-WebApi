using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Models
{
    [Table(name: "Author")]
    public class Author
    {
        [Key]
        public Guid AuthorId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
