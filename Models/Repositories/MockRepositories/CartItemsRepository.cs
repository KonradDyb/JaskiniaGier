using JaskiniaGier.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories.MockRepositories
{
    public class CartItemsRepository
    {
      public IEnumerable<CartItem> CartItems  =>
           new List<CartItem>()
                {
                    new CartItem()
                    {
                        Game = new Game()
                        {
                            Title = "Test",
                            GameId = 123,
                            GameDescription = "Test",
                            SubGenreId = 3,
                            ImagePath = "Test.jpg",
                            Price = 33
                        },

                        Amount = 33,
                        CartItemId = 333

                    },
                    new CartItem()
                    {
                        Game = new Game()
                        {
                            Title = "Test2",
                            GameId = 1234,
                            GameDescription = "Test2",
                            SubGenreId = 4,
                            ImagePath = "Test2.jpg",
                            Price = 11
                        },

                        Amount = 11,
                        CartItemId = 334

                    }
                };

    }
}
