using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public Game Game { get; set; }
        public int GameId { get; set; }
        public ShipAddress Address { get; set; }
        public int ShipAddressId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
