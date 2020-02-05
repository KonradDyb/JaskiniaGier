using JaskiniaGier.Models;
using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Controllers
{
    public class ShipAddressController : Controller
    {
        private readonly IShipAddressRepository _shipAddressRepository;
        private readonly Cart _cart;

        public ShipAddressController(IShipAddressRepository shipAddressRepository, Cart cart)
        {
            _shipAddressRepository = shipAddressRepository;
            _cart = cart;
        }

        public IActionResult Checkout()
        {
            return View();
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
