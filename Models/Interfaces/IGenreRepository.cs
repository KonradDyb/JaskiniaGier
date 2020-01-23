using JaskiniaGier.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Interfaces
{
    public interface IGenreRepository
    {
        public IEnumerable<Genre> Genres { get; }
    }
}
