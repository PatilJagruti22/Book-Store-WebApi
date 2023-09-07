using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Models
{
    [Table(name: "Cart")]
    public class Cart
    {
        [Key]
        public Guid CartId { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}
