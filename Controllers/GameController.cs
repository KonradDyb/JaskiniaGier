using JaskiniaGier.Models;
using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Interfaces;
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
            return View(game);
        }

        public IActionResult ListByGenre(string genre)
        {
            var allGames = _appDbContext.Games.Where(x => x.SubGenre.Genre.GenreName == genre);
            return View(allGames);
        }

        public IActionResult ListBySubGenre(string subGenre)
        {
            var allGames = _appDbContext.Games.Where(x => x.SubGenre.SubGenreName == subGenre);
            return View(allGames);
        }

        public IActionResult ListAllGames()
        {
            var allGames = _appDbContext.Games;
            return View(allGames);
        }
    }
}
