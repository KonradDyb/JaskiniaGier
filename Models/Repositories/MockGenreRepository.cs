using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                }

            };

    }
}
