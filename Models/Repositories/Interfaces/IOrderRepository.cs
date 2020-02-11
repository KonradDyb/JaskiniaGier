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
        void CreateShipDetails(OrderDetails shipAddress);
        IEnumerable<OrderDTO> GetOrder(string userId);
        IEnumerable<Order> GetOrderByIdAndOrderPlaced(string userId, string orderPlaced);
    }
}
