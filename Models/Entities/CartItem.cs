using JaskiniaGier.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Game Game { get; set; }
        public int Amount { get; set; }
        public string CartId { get; set; }
    }
}
