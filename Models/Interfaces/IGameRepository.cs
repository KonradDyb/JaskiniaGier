using JaskiniaGier.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Interfaces
{
    public interface IGameRepository
    {
        IEnumerable<Game> AllGames { get; }
        IEnumerable<Game> GetGamesByGenre(string genre);
        IEnumerable<Game> GetGamesBySubGenre(string subGenre);
    }
}
