using JaskiniaGier.Models;
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
        private readonly IGameRepository _gameRepository;
        private readonly Cart _cart;

        public CartController(IGameRepository gameRepository, Cart cart)
        {
            _gameRepository = gameRepository;
            _cart = cart;
        }

        public ViewResult Index()
        {
            var items = _cart.GetShoppingCartItems();
            _cart.CartItems = items;

            var cartViewModel = new CartViewModel
            {
                Cart = _cart,
                CartTotal = _cart.GetShoppingCartTotal()
            };

            return View(cartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int gameId)
        {
            var selectedGame = _gameRepository.AllGames.FirstOrDefault(x => x.GameId == gameId);

            if(selectedGame != null)
            {
                _cart.AddToCart(selectedGame, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int gameId)
        {
            var selectedGame = _gameRepository.AllGames.FirstOrDefault(x => x.GameId == gameId);

            if (selectedGame != null)
            {
                _cart.RemoveFromCart(selectedGame);
            }
            return RedirectToAction("Index");
        }
        
    }
}
