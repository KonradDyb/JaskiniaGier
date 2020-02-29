using JaskiniaGier.Models;
using JaskiniaGier.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Components
{
    public class CartSummary : ViewComponent
    {
        private readonly Cart _cart;

        public CartSummary(Cart cart)
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
