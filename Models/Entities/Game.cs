namespace JaskiniaGier.Models.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public string GameDescription { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }
        public SubGenre SubGenre { get; set; }
        public int SubGenreId { get; set; }
    }
}
