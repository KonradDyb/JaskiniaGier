using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Interfaces;
using System.Collections.Generic;

namespace JaskiniaGier.Models.Repositories
{
    public class MockGenreRepository : IGenreRepository
    {

        public IEnumerable<Genre> Genres =>
            new List<Genre>
            {
                new Genre
                {
                    GenreId = 1,
                    GenreName = "Fabularne",        
                },

                new Genre
                {
                    GenreId = 2,
                    GenreName = "Przygodowe",
                },

                new Genre
                {
                    GenreId = 3,
                    GenreName = "Strategiczne",
                },
                   new Genre
                {
                    GenreId = 4,
                    GenreName = "Symulacyjne",
                }
            };

    }
}
