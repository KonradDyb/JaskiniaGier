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
    public class ShipAddressController : Controller
    {
        private readonly IShipAddressRepository _shipAddressRepository;
        private readonly Cart _cart;
        private readonly UserManager<IdentityUser> _userManager;

        public ShipAddressController(IShipAddressRepository shipAddressRepository, Cart cart, 
            UserManager<IdentityUser> userManager)
        {
            _shipAddressRepository = shipAddressRepository;
            _cart = cart;
            _userManager = userManager;
        }

        public IActionResult Checkout()
        {
            return View();
            
        }

        public IActionResult GetOrders()
        {
            var userId = _userManager.GetUserId(User);
            var getOrder = _shipAddressRepository.GetOrder(userId);
            
            

            return View(getOrder);
            
        }

        public IActionResult OrderDetails(int orderId)
        {
            var order = _shipAddressRepository.GetOrderById(orderId);

            return View(order);
        }

        [HttpPost]
        public IActionResult Checkout(ShipAddress shipAddress)
        {
            var products = _cart.GetCartItems();
            _cart.CartItems = products;

            if (_cart.CartItems.Count == 0)
            {
                ModelState.AddModelError("", "Twoj koszyk jest pusty. Najpierw dodaj produkt.");
            }

            if (ModelState.IsValid)
            {
                shipAddress.UserId = _userManager.GetUserId(User);
                _shipAddressRepository.CreateShipDetails(shipAddress);
                _cart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(shipAddress);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.Checkout = "Twoje zamówienie zostało złożone pomyślnie.";

            return View();
        }
    }
}
