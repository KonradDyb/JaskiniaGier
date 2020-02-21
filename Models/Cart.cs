using JaskiniaGier.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaskiniaGier.Models
{
    public class Cart
    {
        private readonly AppDbContext _appDbContext;

        public string SessionCartId { get; set; }

        public List<CartItem> CartItems { get; set; }


        public Cart()
        {

        }
        private Cart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
       
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId");

            if (cartId == null)
            {
                cartId = Guid.NewGuid().ToString();
            }
            

            session.SetString("CartId", cartId); 

            return new Cart(context) { SessionCartId = cartId };
           
        }

        public async Task AddToCartAsync(Game game, int amount)
        {
            var shoppingCartItem =
                    await Task.FromResult(_appDbContext.CartItems.SingleOrDefault(
                        x => x.Game.GameId == game.GameId && x.CartId == SessionCartId));

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new CartItem
                {
                    CartId = SessionCartId,
                    Game = game,
                    Amount = amount
                };

                _appDbContext.CartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount += amount ;
            }
            _appDbContext.SaveChanges();
        }

        public async Task RemoveFromCartAsync(Game game)
        {
            var shoppingCartItem =
                    await Task.FromResult(_appDbContext.CartItems.SingleOrDefault(
                        x => x.Game.GameId == game.GameId && x.CartId == SessionCartId));


            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount >= 1)
                {
                    _appDbContext.CartItems.Remove(shoppingCartItem);
                }

            }

            _appDbContext.SaveChanges();

        }

        public async Task<List<CartItem>> GetCartItemsAsync() => await Task.FromResult(CartItems ??
                   (CartItems = _appDbContext.CartItems.Where(x => x.CartId == SessionCartId)
                           .Include(x => x.Game)
                           .ToList()));
     

        public async Task ClearCartAsync()
        {
            var cartItems = await Task.FromResult(_appDbContext
                .CartItems
                .Where(x => x.CartId == SessionCartId));

            _appDbContext.CartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public async Task<int> GetCartTotalAsync() =>
            await Task.FromResult(_appDbContext.CartItems.Where(x => x.CartId == SessionCartId)
                .Select(x => x.Game.Price * x.Amount).Sum());
         
        
    }
}
