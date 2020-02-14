using JaskiniaGier.Models;
using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace JaskiniaGier.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly Cart _cart;
        private readonly UserManager<IdentityUser> _userManager;

        public OrderController(IOrderRepository orderRepository, Cart cart, 
            UserManager<IdentityUser> userManager)
        {
            _orderRepository = orderRepository;
            _cart = cart;
            _userManager = userManager;
        }

        public IActionResult Checkout()
        {
            return View();   
        }

        public async Task<IActionResult> GetOrdersAsync()
        {
            var userId = _userManager.GetUserId(User);
            var getOrder = await _orderRepository.GetOrderAsync(userId);

            if (getOrder.IsAny())
            {
                return View(getOrder);
            }


            return RedirectToAction("EmptyOrder");  
        }

        public IActionResult EmptyOrder()
        {
            return View();
        }

        public async Task<IActionResult> OrderDetailsAsync(string orderPlaced)
        {
            var userId = _userManager.GetUserId(User);
            var order = await _orderRepository.GetOrderByIdAndOrderPlacedAsync(userId, orderPlaced);

            return View(order);
        }

        public IActionResult EmptyCart()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CheckoutAsync(OrderDetails orderDetails)
        {
            var products = await _cart.GetCartItemsAsync();
            _cart.CartItems = products;

            if (_cart.CartItems.Count == 0)
            {
                return await Task.FromResult(RedirectToAction("EmptyCart"));
            }

            if (ModelState.IsValid)
            {
                orderDetails.UserId = _userManager.GetUserId(User);
                await _orderRepository.CreateShipDetailsAsync(orderDetails);
                await _cart.ClearCartAsync();
                return RedirectToAction("CheckoutComplete");
            }

            return View(orderDetails);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.Checkout = "Twoje zamówienie zostało złożone pomyślnie.";

            return View();
        }
    }
}
