using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Models.ViewModels
{
    public class PriceViewModel
    {
        public Guid PriceId { get; set; }
        public string? Currency { get; set; }
        public int? Value { get; set; }
    }
}
