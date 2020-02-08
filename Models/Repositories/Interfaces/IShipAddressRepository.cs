﻿using JaskiniaGier.Models.Entities;
using JaskiniaGier.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories
{
    public interface IShipAddressRepository
    {
        void CreateShipDetails(ShipAddress shipAddress);
        IEnumerable<Order> GetOrder(string userId);
        IEnumerable<Order> GetOrderById(int orderId);
    }
}
