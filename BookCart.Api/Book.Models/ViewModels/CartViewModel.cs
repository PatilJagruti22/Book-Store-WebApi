using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Models.ViewModels
{
    public class CartViewModel
    {
        public Guid CartId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
