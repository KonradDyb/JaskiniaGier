using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JaskiniaGier.Models;
using JaskiniaGier.Models.Interfaces;


namespace JaskiniaGier.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISubGenreRepository _subGenreRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IGameRepository _gameRepository;

        public HomeController(ILogger<HomeController> logger, ISubGenreRepository subGenreRepository,
            IGenreRepository genreRepository, IGameRepository gameRepository)
        {
            _logger = logger;
            _subGenreRepository = subGenreRepository;
            _genreRepository = genreRepository;
            _gameRepository = gameRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListByGenre(string genre)
        {
            var allGames = _gameRepository.Games.Where(x => x.SubGenre.Genre.GenreName == genre);
            return View(allGames);
        }
        public IActionResult ListBySubGenre(string subGenre)
        {
            var allGames = _gameRepository.Games.Where(x => x.SubGenre.SubGenreName == subGenre);
            return View(allGames);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
