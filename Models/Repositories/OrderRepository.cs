using JaskiniaGier.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CartService _cart;

        public OrderRepository(AppDbContext appDbContext, CartService cart)
        {
            _appDbContext = appDbContext;
            _cart = cart;
        }

        public async Task CreateOrderDetailsAsync(Order order)
        {

            order.OrderPlaced = DateTime.Now.ToString();

            var cartItems = _cart.CartItems;
            order.OrderTotal = await _cart.GetCartTotalAsync();
            
            order.OrderItems = new List<OrderItem>();

            foreach (var item in cartItems)
            {
                var orderInfo = new OrderItem
                {
                    Amount = item.Amount,
                    GameId = item.Game.GameId,
                    Price = item.Game.Price
                };


                order.OrderItems.Add(orderInfo);
            }

            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();

        }

        

        public async Task<List<OrderDTO>> GetOrdersByAsync(string userId) =>
       
            await Task.FromResult(_appDbContext.OrderItems.Include(x => x.Order)
                        .Where(x => x.Order.UserId == userId)
                        .AsEnumerable()
                        .GroupBy(x => x.Order.OrderPlaced)
                        .Select(g => new OrderDTO
                        {
                            Id = g.OrderBy(e => e.OrderItemId).FirstOrDefault().OrderItemId,
                            OrderPlaced = g.Key,
                            Total = g.Sum(e => e.Price * e.Amount),
                        }
                         ).ToList());

        public async Task<IIncludableQueryable<OrderItem, Game>> GetOrdersByAsync(string userId, 
            string orderPlaced) =>
        
            await Task.FromResult(_appDbContext.OrderItems.Where(x => x.Order.UserId == userId &&
                                                             x.Order.OrderPlaced == orderPlaced)
                                                                   .Include(x => x.Order)
                                                                    .Include(x => x.Game));
        

       

    }
}
