namespace JaskiniaGier.Models.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public Game Game { get; set; }
        public int GameId { get; set; }
        public Order Order { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
