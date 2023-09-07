using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Models
{
    [Table(name: "Price")]
    public class Price
    {
        [Key]
        public Guid PriceId { get; set; }
        [Required]
        public string? Currency { get; set; }
        public int? Value { get; set; }

    }
}
