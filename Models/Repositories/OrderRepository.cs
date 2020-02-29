using JaskiniaGier.Models.Entities;
using JaskiniaGier.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly Cart _cart;

        public OrderRepository(AppDbContext appDbContext, Cart cart)
        {
            _appDbContext = appDbContext;
            _cart = cart;
        }

        public async Task CreateShipDetailsAsync(OrderDetails shipAddress)
        {

            shipAddress.OrderPlaced = DateTime.Now.ToString();

            var cartProducts = _cart.CartItems;
            shipAddress.OrderTotal = await _cart.GetCartTotalAsync();

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

            _appDbContext.OrderDetails.Add(shipAddress);

            _appDbContext.SaveChanges();

        }

        

        public async Task<List<OrderDTO>> GetOrdersByAsync(string userId) =>
       
            await Task.FromResult(_appDbContext.Orders.Include(x => x.OrderDetails)
                        .Where(x => x.OrderDetails.UserId == userId)
                        .AsEnumerable()
                        .GroupBy(x => x.OrderDetails.OrderPlaced)
                        .Select(g => new OrderDTO
                        {
                            Id = g.OrderBy(e => e.OrderId).FirstOrDefault().OrderId,
                            OrderPlaced = g.Key,
                            Total = g.Sum(e => e.Price * e.Amount),
                        }
                         ).ToList());

        public async Task<IIncludableQueryable<Order, Game>> GetOrdersByAsync(string userId, 
            string orderPlaced) =>
        
            await Task.FromResult(_appDbContext.Orders.Where(x => x.OrderDetails.UserId == userId &&
                                                             x.OrderDetails.OrderPlaced == orderPlaced)
                                                                   .Include(x => x.OrderDetails)
                                                                    .Include(x => x.Game));
        

       

    }
}
