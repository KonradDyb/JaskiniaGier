using JaskiniaGier.Models.Entities;
using System.Collections.Generic;

namespace JaskiniaGier.Models.Interfaces
{
    public interface ISubGenreRepository
    {
        public IEnumerable<SubGenre> SubGenres { get; }
    }
}
