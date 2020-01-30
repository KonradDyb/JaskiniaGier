using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Entities
{
    public class SubGenre
    {
        public int SubGenreId { get; set; }
        public string SubGenreName { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
