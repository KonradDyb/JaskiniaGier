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
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public int Amount { get; set; }
    }
}
