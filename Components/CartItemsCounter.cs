using JaskiniaGier.Models;
using JaskiniaGier.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace JaskiniaGier.Components
{
    public class CartItemsCounter : ViewComponent
    {
        private readonly Cart _cart;

        public CartItemsCounter(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _cart.GetCartItemsAsync();
            _cart.CartItems = items.Result;

            var cartViewModel = new CartViewModel
            {
                Cart = _cart,
                CartTotal =  Convert.ToDecimal(_cart.GetCartTotalAsync().Result)
            };

            return View(cartViewModel);
        }
    }
}
