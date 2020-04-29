using JaskiniaGier.Models.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories
{
    public interface IOrderRepository
    {
        Task CreateOrderDetailsAsync(Order order);
        Task<List<OrderDTO>> GetOrdersByAsync(string userId);
        Task<IIncludableQueryable<OrderItem, Game>> GetOrdersByAsync(string userId, string orderPlaced);
    }
}
