using JaskiniaGier.Models.Entities;
using JaskiniaGier.ViewModels;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories
{
    public interface IOrderRepository
    {
        Task CreateShipDetailsAsync(OrderDetails shipAddress);
        Task<List<OrderDTO>> GetOrdersByAsync(string userId);
        Task<IIncludableQueryable<Order, Game>> GetOrdersByAsync(string userId, string orderPlaced);
    }
}
