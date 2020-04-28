using JaskiniaGier.Models;
using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> ShowCompleteOrdersAsync()
        {
            var userId = _userManager.GetUserId(User);
            var orders = await _orderRepository.GetOrdersByAsync(userId);

            if (orders.IsAny())
            {
                return View(orders);
            }


            return RedirectToAction("EmptyOrder");  
        }

        public IActionResult EmptyOrder()
        {
            return View();
        }

        public async Task<IActionResult> ShowCompleteOrderDetails(string orderPlaced)
        {
            var userId = _userManager.GetUserId(User);
            var order = await _orderRepository.GetOrdersByAsync(userId, orderPlaced);

            return View(order);
        }

        public IActionResult EmptyCart()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CheckoutAsync(Order order)
        {
            var items = await _cart.GetCartItemsAsync();
            _cart.CartItems = items;

            if (_cart.CartItems.Count == 0)
            {
                return await Task.FromResult(RedirectToAction("EmptyCart"));
            }

            if (ModelState.IsValid)
            {
                order.UserId = _userManager.GetUserId(User);
                await _orderRepository.CreateShipDetailsAsync(order);
                await _cart.ClearCartAsync();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.Checkout = "Twoje zamówienie zostało złożone pomyślnie.";

            return View();
        }
    }
}
