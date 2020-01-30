using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _appDbContext;

        public GameRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Game> AllGames => _appDbContext.Games;

        public IEnumerable<Game> GetGamesByGenre(string genre)
        {
            return _appDbContext.Games.Where(x => x.SubGenre.Genre.GenreName == genre).AsNoTracking();
        }

        public IEnumerable<Game> GetGamesBySubGenre(string subGenre)
        {
            return _appDbContext.Games.Where(x => x.SubGenre.SubGenreName == subGenre).AsNoTracking();
        }

    }
}

