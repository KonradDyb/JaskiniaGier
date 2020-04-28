using JaskiniaGier.Models;
using JaskiniaGier.Models.Entities;
using JaskiniaGier.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        public async Task<ViewResult> Index()
        {
            var items = await _cart.GetCartItemsAsync();
            _cart.CartItems = items;

            var cartViewModel = new CartViewModel
            {
                Cart = _cart,
                CartTotal = _cart.GetCartTotalAsync().Result
            };

            return View(cartViewModel);

        }

        public IActionResult EmptyCart()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> GoToPaymentAsync()
        {
            var items = await _cart.GetCartItemsAsync();
            if(items.Count == 0)
            {
                return RedirectToAction("EmptyCart");
            }
            return View();
        }

        [HttpPost]
        public async Task<RedirectToActionResult> AddToCartAsync(GameViewModel gameView, int gameId)
        {

            var selectedGame = await GetGameByIdAsync(gameId);

            if(selectedGame != null)
            {
                await _cart.AddToCartAsync(selectedGame, gameView.Amount);
            }

            return RedirectToAction("Index");
        }

        public async Task<RedirectToActionResult> RemoveItemFromCartAsync(int gameId)
        {
            var selectedGame = await GetGameByIdAsync(gameId);

            if (selectedGame != null)
            {
                await _cart.RemoveFromCartAsync(selectedGame);
            }

            return RedirectToAction("Index");
        }

        private async Task<Game> GetGameByIdAsync(int gameId) => await Task.FromResult(_appDbContext.Games.FirstOrDefault(x => x.GameId == gameId));
        
        public async Task<RedirectToActionResult> ClearCartAsync()
        {
            await _cart.ClearCartAsync();
            return RedirectToAction("Index");
        }
    }
}
