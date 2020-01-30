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
        private readonly IGameRepository _gameRepository;
        private readonly AppDbContext _appDbContext;

        public GameController(IGameRepository gameRepository, AppDbContext appDbContext)
        {
            _gameRepository = gameRepository;
            _appDbContext = appDbContext;
        }


        public IActionResult ShowDetails(int productId)
        {
            var game = _gameRepository.GetGameById(productId);
            return View(game);
        }

        public IActionResult ListByGenre(string genre)
        {
            var allGames = _gameRepository.GetGamesByGenre(genre);
            return View(allGames);
        }
        public IActionResult ListBySubGenre(string subGenre)
        {
            var allGames =  _gameRepository.GetGamesBySubGenre(subGenre);
            return View(allGames);
        }
    }
}
