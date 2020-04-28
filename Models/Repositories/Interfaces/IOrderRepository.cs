using JaskiniaGier.Models.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories
{
    public interface IOrderRepository
    {
        Task CreateShipDetailsAsync(Order order);
        Task<List<OrderDTO>> GetOrdersByAsync(string userId);
        Task<IIncludableQueryable<OrderItems, Game>> GetOrdersByAsync(string userId, string orderPlaced);
    }
}
