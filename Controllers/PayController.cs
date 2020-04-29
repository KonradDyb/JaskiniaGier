using JaskiniaGier.Models;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Threading.Tasks;

namespace JaskiniaGier.Controllers
{
    public class PayController : Controller
    {
        private readonly CartService _cart;

        public PayController(CartService cart)
        {
            _cart = cart;
        }

        public async Task<IActionResult> Charge(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();

            var cartTotal = _cart.GetCartTotalAsync().Result.ToString();
            cartTotal += "00";

            var customer = await customers.CreateAsync(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            if(cartTotal == "000")
            {
                return RedirectToAction("EmptyCart");
            }

            var charge = await charges.CreateAsync(new ChargeCreateOptions
            {
                Amount = Convert.ToInt64(cartTotal),
                Description = "Test Payment",
                Currency = "pln",
                Customer = customer.Id,
                ReceiptEmail = stripeEmail,
               
            });

            if (charge.Status == "succeeded")
            {
                
                return View();
            }

            else 
            {
                return View();
            }

           
        }
    }
}
