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
                    Title = "Wiedźmin Edycja Rozszerzona",
                    GameDescription = "Nazywasz się Geralt z Rivii i jesteś wiedźminem, czyli za pieniądze zabijasz potwory. Przeszedłeś specjalne szkolenie, aby być najlepszym w swoim fachu, a twoje ciało zostało wzmocnione silnymi eliksirami. Masz amnezję i nie pamiętasz swojej przeszłości. Kaer Morhen, ostatnia twierdza wiedźminów, zostało zaatakowane przez tajemniczą organizację, gdy zaczynałeś leczyć tam swoje rany. Wygraliście bitwę, lecz straciliście sekretny przepis na mutagen - substancję potrzebną do tworzenia wiedźminów. Ci z twoich braci, którzy ocaleli, wyruszają, aby go odnaleźć i ukarać winnych. Pamiętasz czy nie, jesteś teraz jednym z nich.",
                    ImagePath = "witcher.jpg",
                    Price = "30 PLN",
                    SubGenre = _subGenreRepository.SubGenres.ToList()[0]
                }
            };

     
  
    }
}
