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


        public IActionResult ShowDetails(int productId)
        {
            var game = _appDbContext.Games.FirstOrDefault(x => x.GameId == productId);
            var gameView = new GameViewModel
            {
                Game = game
            };

            return View(gameView);
        }

        public IActionResult ListByGenre(string genre)
        {
            var allGames = _appDbContext.Games.Where(x => x.SubGenre.Genre.GenreName == genre);
            var gameView = GetGameViewModel(allGames);

            return View(gameView);
        }

        public IActionResult ListBySubGenre(string subGenre)
        {
            var allGames = _appDbContext.Games.Where(x => x.SubGenre.SubGenreName == subGenre);
            var gameView = GetGameViewModel(allGames);

            return View(gameView);
        }

        public IActionResult ListAllGames()
        {
            var allGames = _appDbContext.Games;
            var gameView = GetGameViewModel(allGames);

            return View(gameView);
        }

        private static GameViewModel GetGameViewModel(IQueryable<Game> allGames)
        {
            return new GameViewModel
            {
                Games = allGames
            };
        }
    }
}
