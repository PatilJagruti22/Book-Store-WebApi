using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Models.ViewModels
{
    public class BookCartViewModel
    {
        public Guid BookId { get; set; }
        public string? Title { get; set; }
        public int TotalPages { get; set; }
        public Price? Price { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedOn { get; set; }
        public List<Author>? Authors { get; set; }
    }
}
