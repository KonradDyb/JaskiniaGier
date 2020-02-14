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
    public class GameController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public GameController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<IActionResult> ShowDetailsAsync(int productId)
        {
            var game = await Task.FromResult(_appDbContext.Games.FirstOrDefault(x => x.GameId == productId));
            var gameView = new GameViewModel
            {
                Game = game
            };

            return await Task.FromResult(View(gameView));
        }

        public async Task<IActionResult> ListByGenreAsync(string genre)
        {
            var allGames = await Task.FromResult(_appDbContext.Games.Where(x => x.SubGenre.Genre.GenreName == genre));
            var gameView = GetGameViewModel(allGames);

            return View(gameView);
        }

        public async Task<IActionResult> ListBySubGenreAsync(string subGenre)
        {
            var allGames = await Task.FromResult(_appDbContext.Games.Where(x => x.SubGenre.SubGenreName == subGenre));
            var gameView = GetGameViewModel(allGames);

            return View(gameView);
        }



        public async Task<IActionResult> ListAllGamesAsync()
        {
            var allGames = await Task.FromResult(_appDbContext.Games);
            var gameView =  GetGameViewModel(allGames);

            return View(gameView);
        }

        private static GameViewModel GetGameViewModel(IEnumerable<Game> allGames)
        {
            return new GameViewModel
            {
                Games = allGames
            };
        }

        public async Task<IQueryable<Game>> GetGamesByAsync(Func<Game, string> propertySelector, string genre)
        {
            return await Task.FromResult(_appDbContext.Games.Where(x => propertySelector(x) == genre));
        }
    }
}
