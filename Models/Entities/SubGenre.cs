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
