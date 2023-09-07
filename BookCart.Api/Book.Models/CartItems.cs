using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Models
{
    [Table(name: "Cart Item")]
    public class CartItems
    {
        [Key]
        public Guid CartItemId { get; set; }
        [Required]
        [ForeignKey("Cart")]
        public Guid? CartId { get; set; }
        public virtual Cart? Cart { get; set; }
        [ForeignKey("Book")]
        public Guid BookId { get; set; }
        public virtual BookCart? Book { get; set; }
        public int Quantity { get; set; }
    }
}
