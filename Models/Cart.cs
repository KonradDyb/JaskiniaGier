using JaskiniaGier.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JaskiniaGier.Models
{
    public class Cart
    {
        private readonly AppDbContext _appDbContext;

        public string SessionCartId { get; set; }

        public List<CartItem> CartItems { get; set; }

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

        public void AddToCart(Game game, int amount)
        {
            var shoppingCartItem =
                    _appDbContext.CartItems.SingleOrDefault(
                        x => x.Game.GameId == game.GameId && x.CartId == SessionCartId);

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
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Game game)
        {
            var shoppingCartItem =
                    _appDbContext.CartItems.SingleOrDefault(
                        x => x.Game.GameId == game.GameId && x.CartId == SessionCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.CartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<CartItem> GetCartItems()
        {
            return CartItems ??
                   (CartItems =
                       _appDbContext.CartItems.Where(x => x.CartId == SessionCartId)
                           .Include(x => x.Game)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext
                .CartItems
                .Where(x => x.CartId == SessionCartId);

            _appDbContext.CartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetCartTotal()
        {
            var total = _appDbContext.CartItems.Where(x => x.CartId == SessionCartId)
                .Select(x => x.Game.Price * x.Amount).Sum();
            return total;
        }
    }
}
