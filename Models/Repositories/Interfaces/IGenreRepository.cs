using JaskiniaGier.Models.Entities;
using System.Collections.Generic;

namespace JaskiniaGier.Models.Interfaces
{
    public interface IGenreRepository
    {
        public IEnumerable<Genre> Genres { get; }
    }
}
