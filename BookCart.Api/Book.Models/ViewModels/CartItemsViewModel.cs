using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Models.ViewModels
{
    public class CartItemsViewModel
    {
        public Guid CartItemId { get; set; }
        public Guid? CartId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
    }
}
