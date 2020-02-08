using JaskiniaGier.Models;
using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Interfaces;
using JaskiniaGier.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly Cart _cart;

        public CartController(AppDbContext appDbContext, Cart cart)
        {
            _appDbContext = appDbContext;
            _cart = cart;
        }

        public ViewResult Index()
        {
            var items = _cart.GetCartItems();
            _cart.CartItems = items;

            var cartViewModel = new CartViewModel
            {
                Cart = _cart,
                CartTotal = _cart.GetCartTotal()
            };

            return View(cartViewModel);

        }

        [HttpPost]
        public RedirectToActionResult AddToCart(GameViewModel gameView, int gameId)
        {

            var selectedGame = GetGameById(gameId);

            if(selectedGame != null)
            {
                _cart.AddToCart(selectedGame, gameView.Amount);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int gameId)
        {
            var selectedGame = GetGameById(gameId);

            if (selectedGame != null)
            {
                _cart.RemoveFromCart(selectedGame);
            }

            return RedirectToAction("Index");
        }

        private Game GetGameById(int gameId)
        {
            return _appDbContext.Games.FirstOrDefault(x => x.GameId == gameId);
        }

        public RedirectToActionResult ClearCart()
        {
            _cart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
