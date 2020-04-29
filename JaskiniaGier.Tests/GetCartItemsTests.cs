using JaskiniaGier.Models;
using JaskiniaGier.Models.Repositories.MockRepositories;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JaskiniaGier.Tests
{
    public class GetCartItemsTests : TestBase
    {
        [Fact]
        public async Task ShouldReturn2CartItems()
        {
            //Arrange
            UseSqlServer();
            using var context = GetDbContext();
            var cart = new Mock<CartService>();
            var cartItemsRepo = new CartItemsRepository();
            cart.Object.CartItems = cartItemsRepo.CartItems.ToList();

            //Act
            var result = await cart.Object.GetCartItemsAsync();

            //Assert
            Assert.NotEmpty(result);
            Assert.Equal(2, result.Count());
            Assert.Contains(result, r => r.Game.Title == "Test2");
            Assert.DoesNotContain(result, r => r.Game.Title == "Test60");
        }



       [Fact]
        public async Task CheckIfCartIsEmpty()
        {
            //Arrange
            UseSqlServer();
            using var context = GetDbContext();
            var cart = new Mock<CartService>();
            cart.Object.CartItems = new List<CartItem>();

            //Act
            var result = await cart.Object.GetCartItemsAsync();

            //Assert
            Assert.Empty(result);

        }

       
    }
}
