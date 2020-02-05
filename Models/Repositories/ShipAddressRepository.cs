﻿using JaskiniaGier.Models.Entities;
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

      
    }
}
