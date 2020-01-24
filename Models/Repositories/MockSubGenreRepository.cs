using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    SubGenreName = "TTP",
                    Genre = _genreRepository.Genres.ToList()[0]
                }

            };

   
    }
}
