using JaskiniaGier.Models.Entities;
using System.Collections.Generic;

namespace JaskiniaGier.Models.Interfaces
{
    public interface IGameRepository
    {
        IEnumerable<Game> AllGames { get; }
        IEnumerable<Game> GetGamesByGenre(string genre);
        IEnumerable<Game> GetGamesBySubGenre(string subGenre);
        Game GetGameById(int gameId);

    }
}
