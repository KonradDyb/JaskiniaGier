using JaskiniaGier.Models.Entities;
using JaskiniaGier.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Repositories
{
    public class MockGameRepository : IGameRepository
    {

        private readonly ISubGenreRepository _subGenreRepository = new MockSubGenreRepository();



        public IEnumerable<Game> Games =>

            new List<Game>
            {
                new Game
                {
                    GameId = 1,
                    Title = "Wiedźmin 1",
                    GameDescription = "Nazywasz się Geralt z Rivii i jesteś wiedźminem, czyli za pieniądze zabijasz potwory. Przeszedłeś specjalne szkolenie, aby być najlepszym w swoim fachu, a twoje ciało zostało wzmocnione silnymi eliksirami. Masz amnezję i nie pamiętasz swojej przeszłości. Kaer Morhen, ostatnia twierdza wiedźminów, zostało zaatakowane przez tajemniczą organizację, gdy zaczynałeś leczyć tam swoje rany. Wygraliście bitwę, lecz straciliście sekretny przepis na mutagen - substancję potrzebną do tworzenia wiedźminów. Ci z twoich braci, którzy ocaleli, wyruszają, aby go odnaleźć i ukarać winnych. Pamiętasz czy nie, jesteś teraz jednym z nich.",
                    ImagePath = "wiedzmin.jpg",
                    Price = "30,00 ZŁ",
                    SubGenre = _subGenreRepository.SubGenres.ToList()[0]
                },
                new Game
                {
                    GameId = 2,
                    Title = "Anno 1800",
                    GameDescription = "Strategia ekonomiczna od Ubisoftu",
                    ImagePath = "anno.jpg",
                    Price = "100,00 ZŁ",
                    SubGenre = _subGenreRepository.SubGenres.ToList()[5]
                },
                 new Game
                {
                    GameId = 3,
                    Title = "Gothic",
                    GameDescription = "RPG od Piranha Bytes",
                    ImagePath = "gothic.jpg",
                    Price = "10,00 ZŁ",
                    SubGenre = _subGenreRepository.SubGenres.ToList()[0]
                },
                 new Game
                {
                    GameId = 4,
                    Title = "Diablo",
                    GameDescription = "Hack&Slash od Blizzarda",
                    ImagePath = "diablo.jpg",
                    Price = "30,00 ZŁ",
                    SubGenre = _subGenreRepository.SubGenres.ToList()[1]
                },
                 new Game
                {
                    GameId = 5,
                    Title = "Commandos",
                    GameDescription = "Strategia taktyczna od Pyro Studios",
                    ImagePath = "commandos.jpg",
                    Price = "10,00 ZŁ",
                    SubGenre = _subGenreRepository.SubGenres.ToList()[4]
                },
                 new Game
                {
                    GameId = 6,
                    Title = "RimWorld",
                    GameDescription = "Strategia RTS od Ludeon Studios",
                    ImagePath = "rimworld.jpg",
                    Price = "130,00 ZŁ",
                    SubGenre = _subGenreRepository.SubGenres.ToList()[3]
                },
                  new Game
                {
                    GameId = 7,
                    Title = "World Of Warcraft",
                    GameDescription = "Rozszerzenie do WoWa",
                    ImagePath = "wow.jpg",
                    Price = "170,00 ZŁ",
                    SubGenre = _subGenreRepository.SubGenres.ToList()[2]
                }
            };

        public IEnumerable<Game> GetGamesByGenre(string genre)
        {
            return Games.Where(x => x.SubGenre.Genre.GenreName == genre);
        }

        public IEnumerable<Game> GetGamesBySubGenre(string subGenre)
        {
            return Games.Where(x => x.SubGenre.SubGenreName == subGenre);
        }

    }
}
