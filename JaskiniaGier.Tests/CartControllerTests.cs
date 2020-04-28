using FluentAssertions;
using JaskiniaGier.Controllers;
using JaskiniaGier.Models;
using JaskiniaGier.Models.Repositories.MockRepositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JaskiniaGier.Tests
{
    public class CartControllerTests : TestBase
    {
      
        public CartController Controller { get; set; }
        Mock<Cart> _cart;
        Mock<CartItemsRepository> _cartItemsRepo;

        public CartControllerTests()
        {
            UseSqlServer();
            _cart = new Mock<Cart>();
            _cartItemsRepo = new Mock<CartItemsRepository>();
        }

        [Fact]
        public async Task ShouldReturnViewResult()
        {
            //Arrange
            using var context = GetDbContext();
            _cart.Object.CartItems = _cartItemsRepo.Object.CartItems.ToList();
            Controller = new CartController(context,_cart.Object);

            //Act
            var result = await Controller.GoToPaymentAsync();

            //Assert
            result.Should().BeOfType<ViewResult>();
           

        }

        [Fact]
        public async Task ShouldReturnRedirectToActionResult()
        {
            //Arrange
            using var context = GetDbContext();
            _cart.Object.CartItems = new List<CartItem>();
            Controller = new CartController(context, _cart.Object);

            //Act
            var result = await Controller.GoToPaymentAsync();

            //Assert
            result.Should().BeOfType<RedirectToActionResult>();
        }
    }
}
