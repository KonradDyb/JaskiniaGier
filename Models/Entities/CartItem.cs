using JaskiniaGier.Models.Entities;

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
