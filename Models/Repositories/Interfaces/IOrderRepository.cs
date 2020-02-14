using JaskiniaGier.Models.Entities;
using JaskiniaGier.ViewModels;
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
        Task<IEnumerable<OrderDTO>> GetOrderAsync(string userId);
        Task<IEnumerable<Order>> GetOrderByIdAndOrderPlacedAsync(string userId, string orderPlaced);
       
    }
}
