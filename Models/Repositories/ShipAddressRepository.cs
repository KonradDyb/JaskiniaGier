using JaskiniaGier.Models.Entities;
using JaskiniaGier.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories
{
    public class ShipAddressRepository : IShipAddressRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly Cart _cart;

        public ShipAddressRepository(AppDbContext appDbContext, Cart cart)
        {
            _appDbContext = appDbContext;
            _cart = cart;
        }

        public void CreateShipDetails(ShipAddress shipAddress )
        {

            shipAddress.OrderPlaced = DateTime.Now;

            var cartProducts = _cart.CartItems;
            shipAddress.OrderTotal = _cart.GetCartTotal();

            shipAddress.Orders = new List<Order>();

            foreach (var product in cartProducts)
            {
                var orderInfo = new Order
                {
                    Amount = product.Amount,
                    GameId = product.Game.GameId,
                    Price = product.Game.Price
                };


                shipAddress.Orders.Add(orderInfo);
            }

            _appDbContext.ShipAddresses.Add(shipAddress);

            _appDbContext.SaveChanges();

        }

        public IEnumerable<Order> GetOrder(string userId)
        {
            var order = _appDbContext.Orders.Where(x => x.Address.UserId == userId)
                                            .Include(x => x.Address)
                                            .Include(x => x.Game);

            return order;
        }

        public IEnumerable<Order> GetOrderById(int orderId)
        {
            var order = _appDbContext.Orders.Where(x => x.OrderId == orderId)
                                            .Include(x => x.Game);
                                            

            return order;
        }

      
    }
}
