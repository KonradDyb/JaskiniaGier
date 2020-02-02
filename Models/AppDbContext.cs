using JaskiniaGier.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<SubGenre> SubGenres { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 1, GenreName = "Fabularne" });
            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 2, GenreName = "Przygodowe" });
            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 3, GenreName = "Strategiczne" });
            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 4, GenreName = "Symulacyjne" });

            modelBuilder.Entity<SubGenre>().HasData(new SubGenre { SubGenreId = 1, SubGenreName = null, 
                GenreId = 1 });
            modelBuilder.Entity<SubGenre>().HasData(new SubGenre { SubGenreId = 2, SubGenreName = "Hack & Slash",
                GenreId = 1 });
            modelBuilder.Entity<SubGenre>().HasData(new SubGenre { SubGenreId = 3, SubGenreName = "MMORPG",
                GenreId = 1 });
            modelBuilder.Entity<SubGenre>().HasData(new SubGenre { SubGenreId = 4, SubGenreName = "RTS", 
                GenreId = 3});
            modelBuilder.Entity<SubGenre>().HasData(new SubGenre { SubGenreId = 5, SubGenreName = "Taktyczne", 
                GenreId = 3 });
            modelBuilder.Entity<SubGenre>().HasData(new SubGenre { SubGenreId = 6, SubGenreName = "Ekonomiczne", 
                GenreId = 3 });
            modelBuilder.Entity<SubGenre>().HasData(new SubGenre { SubGenreId = 7, SubGenreName = null, 
                GenreId = 4 });


            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 1,
                Title = "Wiedźmin 1",
                GameDescription = "Nazywasz się Geralt z Rivii i jesteś wiedźminem, czyli za pieniądze zabijasz potwory. Przeszedłeś specjalne szkolenie, aby być najlepszym w swoim fachu, a twoje ciało zostało wzmocnione silnymi eliksirami. Masz amnezję i nie pamiętasz swojej przeszłości. Kaer Morhen, ostatnia twierdza wiedźminów, zostało zaatakowane przez tajemniczą organizację, gdy zaczynałeś leczyć tam swoje rany. Wygraliście bitwę, lecz straciliście sekretny przepis na mutagen - substancję potrzebną do tworzenia wiedźminów. Ci z twoich braci, którzy ocaleli, wyruszają, aby go odnaleźć i ukarać winnych. Pamiętasz czy nie, jesteś teraz jednym z nich.",
                ImagePath = "wiedzmin.jpg",
                Price = 30.99M,
                SubGenreId = 1

            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 2,
                Title = "Anno 1800",
                GameDescription = "Anno 1800 jest kolejną odsłoną popularnego cyklu strategii ekonomicznych, nad którą pieczę sprawuje należące do firmy Ubisoft studio Blue Byte. Jak sugeruje tytuł produkcji jej akcja została osadzona w czasach rewolucji przemysłowej – mowa o epoce doniosłych odkryć geograficznych i naukowych oraz wszechobecnej industrializacji.",
                ImagePath = "anno.jpg",
                Price = 100.99M,
                SubGenreId = 6

            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 3,
                Title = "Gothic",
                GameDescription = "Akcja gry przenosi graczy do fantastycznego Królestwa Myrtany, którym rządzi król Rhobar II. Wcielając się w postać Bezimienngo trafiają oni do kolonii karnej na wyspie Khorinis. Otacza ją magiczna, przenikalna jedynie z zewnątrz bariera, którą stworzyli arcymagowie. Niestety, w trakcie inkantacji wydarzyło się coś niespodziewanego. Zasięg zaklęcia okazał się większy niż przewidywano i bariera otoczyła cały obszar Górniczej Doliny, więżąc także magów.",
                ImagePath = "gothic.jpg",
                Price = 12.99M,
                SubGenreId = 1
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 4,
                Title = "Diablo",
                GameDescription = "Akcja Diablo osadzona została w fantastycznym świecie Sanktuarium. Fabuła gry przedstawia zmagania z tytułowym Panem Terroru, który uwięziony w magicznym kamieniu dusz próbuje wydostać się z niewoli. Demon zdołał przeniknąć do umysłu arcybiskupa Lazarusa, prawej ręki władcy królestwa Khanduras. Następnie opętał króla Leorica, a z sennych koszmarów jego pierworodnego potomka stworzył armię przerażających kreatur krążących wokół miasteczka Tristram i pod jego powierzchnią. Nie bacząc na niebezpieczeństwo książę Aidan wyrusza, by stawić czoła siłom zła i pokonać Diablo.",
                ImagePath = "diablo.jpg",
                Price = 30.99M,
                SubGenreId = 2
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 5,
                Title = "Commandos",
                GameDescription = "Commandos to taktyczna gra akcji rozgrywana w czasie rzeczywistym. Gra umiejscowiona jest w realiach II Wojny Światowej gdzie grupa komandosów, prowadzona przez gracza, ma do wykonania szereg trudnych misji za linią frontu. Powodzenie każdej z misji może zależeć od dokładnie przemyślanej strategii, zaplanowania każdego działania oraz zsynchronizowania poczynań swoich ludzi przy ataku na wroga.",
                ImagePath = "commandos.jpg",
                Price = 10.99M,
                SubGenreId = 5
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 6,
                Title = "Frostpunk",
                GameDescription = "Frostpunk jest połączeniem strategii czasu rzeczywistego i city buildera, wzbogaconym o wyraźnie zarysowane elementy survivalowe (twórcy mówią wręcz o opracowaniu nowego gatunku, nazwanego przez nich „society survival”). Za produkcję odpowiada polski zespół 11 bit studios, który zdobył światową sławę dzięki ciepło przyjętym grom z serii Anomaly oraz bestsellerowemu This War of Mine. Produkcja została wydana wyłącznie na platformie PC.",
                ImagePath = "frostpunk.jpg",
                Price = 44.99M,
                SubGenreId = 4
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 7,
                Title = "World Of Warcraft",
                GameDescription = "World of WarCraft to pozycja, która należy do gatunku cRPG. Przygotowana została specjalnie z myślą o rozgrywce w trybie massive online multiplayer, gdzie w szranki stanąć może tysiące graczy z całego świata. Gra przenosi nas do starganego różnymi wojnami i zniszczeniem fantastycznego świata Azeroth - znanego z serii WarCraft.",
                ImagePath = "wow.jpg",
                Price = 90.99M,
                SubGenreId = 3
            }); 
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 8,
                Title = "Sid Meier's Civilization VI",
                GameDescription = "Poprzednia, piąta odsłona marki była swoistym restartem serii, upraszczającym wiele elementów, które mogliśmy znaleźć w poprzedniczkach, w związku z czym na starcie brakowało w niej licznych aspektów rozgrywki z wcześniejszych Cywilizacji. W przypadku szóstej części cyklu twórcy nie chcieli popełniać tego samego błędu, więc większość nowości wprowadzonych przez piątkę i jej dodatki na podstawie sugestii graczy znalazła miejsce także w „podstawce” Sid Meier’s Civilization VI. ",
                ImagePath = "civ.jpg",
                Price = 52.99M,
                SubGenreId = 6
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 9,
                Title = "Farming Simulator 19",
                GameDescription = "Farming Simulator 19 jest kolejną odsłoną znanego cyklu symulatorów, w których wcielamy się w rolnika. Gra oferuje dwie duże, otwarte i pełne różnego rodzaju zadań lokacje oraz setki maszyn i pojazdów, które możemy wykorzystać przy pracy. Za stworzenie omawianej produkcji odpowiada niezmiennie studio GIANTS Software.",
                ImagePath = "farming.jpg",
                Price = 78.99M,
                SubGenreId = 7
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 10,
                Title = "Green Hell",
                GameDescription = "Green Hell jest grą survivalową, opracowaną przez niezależny polski zespół Creepy Jar; w jego skład wchodzą osoby, które wcześniej pracowały między innymi nad Dying Light oraz grami z serii Dead Island.W trakcie zabawy w Green Hell wcielamy się w nieszczęśnika pozostawionego na pastwę losu w amazońskiej dżungli. Chcąc ujść z życiem, bohater (początkowo wyposażony jedynie w radio, z którego przemawia do niego ukochana) musi od podstaw nauczyć się sztuki przetrwania.",
                ImagePath = "greenhell.jpg",
                Price = 85.99M,
                SubGenreId = 7
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 11,
                Title = "Euro Truck Simulator 2",
                GameDescription = "Euro Truck Simulator 2 to druga odsłona symulatora od SCS Software, w którym zasiadamy za sterami potężnych samochodów ciężarowych. Tytuł wprowadza szereg usprawnień w stosunku do poprzedniczki, które miały za zadanie urealnić rozgrywkę. Dla fanów tego typu pozycji cenną informacją powinien być fakt, że za grę odpowiadają między innymi ludzie pracujący wcześniej nad Hard Truck 18 Wheels of Steel – inną produkcją o tej tematyce.",
                ImagePath = "eurotruck.jpg",
                Price = 27.99M,
                SubGenreId = 7
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 12,
                Title = "The Sims 4",
                GameDescription = "Czwarta część The Sims, podobnie jak poprzedniczki unika rewolucyjnych zmian w modelu rozgrywki stawiając na powolną ewolucję sprawdzonych rozwiązań. W trakcie gry nadal opiekujemy się więc rodziną wirtualnych Simów dbając o ich wszystkie potrzeby, zarówno duchowe jak i materialne, a także zapewniając dach nad głową, projektując dom oraz ogród.",
                ImagePath = "sims4.jpg",
                Price = 55.99M,
                SubGenreId = 7
            });
        }
    }
}
