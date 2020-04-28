using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace JaskiniaGier.Models.Repositories
{
    public class MockSubGenreRepository : ISubGenreRepository
    {
        private readonly IGenreRepository _genreRepository = new MockGenreRepository();

        public IEnumerable<SubGenre> SubGenres =>
            new List<SubGenre>
            {
                new SubGenre
                {
                    SubGenreId = 1,
                    SubGenreName = null,
                    Genre = _genreRepository.Genres.ToList()[0]
                },
                new SubGenre
                {
                    SubGenreId = 2,
                    SubGenreName = "Hack & Slash",
                    Genre = _genreRepository.Genres.ToList()[0]
                },
                new SubGenre
                {
                    SubGenreId = 3,
                    SubGenreName = "MMORPG",
                    Genre = _genreRepository.Genres.ToList()[0]
                },
                new SubGenre
                {
                    SubGenreId = 4,
                    SubGenreName = "RTS",
                    Genre = _genreRepository.Genres.ToList()[2]
                },
                new SubGenre
                {
                    SubGenreId = 5,
                    SubGenreName = "Taktyczne",
                    Genre = _genreRepository.Genres.ToList()[2]
                },
                new SubGenre
                {
                    SubGenreId = 6,
                    SubGenreName = "Ekonomiczne",
                    Genre = _genreRepository.Genres.ToList()[2]
                },
                new SubGenre
                {
                    SubGenreId = 7,
                    SubGenreName = null,
                    Genre = _genreRepository.Genres.ToList()[3]
                }
            };

   
    }
}
