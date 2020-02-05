﻿// <auto-generated />
using System;
using JaskiniaGier.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JaskiniaGier.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JaskiniaGier.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.HasIndex("GameId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("JaskiniaGier.Models.Entities.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SubGenreId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("SubGenreId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            GameDescription = "Nazywasz się Geralt z Rivii i jesteś wiedźminem, czyli za pieniądze zabijasz potwory. Przeszedłeś specjalne szkolenie, aby być najlepszym w swoim fachu, a twoje ciało zostało wzmocnione silnymi eliksirami. Masz amnezję i nie pamiętasz swojej przeszłości. Kaer Morhen, ostatnia twierdza wiedźminów, zostało zaatakowane przez tajemniczą organizację, gdy zaczynałeś leczyć tam swoje rany. Wygraliście bitwę, lecz straciliście sekretny przepis na mutagen - substancję potrzebną do tworzenia wiedźminów. Ci z twoich braci, którzy ocaleli, wyruszają, aby go odnaleźć i ukarać winnych. Pamiętasz czy nie, jesteś teraz jednym z nich.",
                            ImagePath = "wiedzmin.jpg",
                            Price = 30.99m,
                            SubGenreId = 1,
                            Title = "Wiedźmin 1"
                        },
                        new
                        {
                            GameId = 2,
                            GameDescription = "Anno 1800 jest kolejną odsłoną popularnego cyklu strategii ekonomicznych, nad którą pieczę sprawuje należące do firmy Ubisoft studio Blue Byte. Jak sugeruje tytuł produkcji jej akcja została osadzona w czasach rewolucji przemysłowej – mowa o epoce doniosłych odkryć geograficznych i naukowych oraz wszechobecnej industrializacji.",
                            ImagePath = "anno.jpg",
                            Price = 100.99m,
                            SubGenreId = 6,
                            Title = "Anno 1800"
                        },
                        new
                        {
                            GameId = 3,
                            GameDescription = "Akcja gry przenosi graczy do fantastycznego Królestwa Myrtany, którym rządzi król Rhobar II. Wcielając się w postać Bezimienngo trafiają oni do kolonii karnej na wyspie Khorinis. Otacza ją magiczna, przenikalna jedynie z zewnątrz bariera, którą stworzyli arcymagowie. Niestety, w trakcie inkantacji wydarzyło się coś niespodziewanego. Zasięg zaklęcia okazał się większy niż przewidywano i bariera otoczyła cały obszar Górniczej Doliny, więżąc także magów.",
                            ImagePath = "gothic.jpg",
                            Price = 12.99m,
                            SubGenreId = 1,
                            Title = "Gothic"
                        },
                        new
                        {
                            GameId = 4,
                            GameDescription = "Akcja Diablo osadzona została w fantastycznym świecie Sanktuarium. Fabuła gry przedstawia zmagania z tytułowym Panem Terroru, który uwięziony w magicznym kamieniu dusz próbuje wydostać się z niewoli. Demon zdołał przeniknąć do umysłu arcybiskupa Lazarusa, prawej ręki władcy królestwa Khanduras. Następnie opętał króla Leorica, a z sennych koszmarów jego pierworodnego potomka stworzył armię przerażających kreatur krążących wokół miasteczka Tristram i pod jego powierzchnią. Nie bacząc na niebezpieczeństwo książę Aidan wyrusza, by stawić czoła siłom zła i pokonać Diablo.",
                            ImagePath = "diablo.jpg",
                            Price = 30.99m,
                            SubGenreId = 2,
                            Title = "Diablo"
                        },
                        new
                        {
                            GameId = 5,
                            GameDescription = "Commandos to taktyczna gra akcji rozgrywana w czasie rzeczywistym. Gra umiejscowiona jest w realiach II Wojny Światowej gdzie grupa komandosów, prowadzona przez gracza, ma do wykonania szereg trudnych misji za linią frontu. Powodzenie każdej z misji może zależeć od dokładnie przemyślanej strategii, zaplanowania każdego działania oraz zsynchronizowania poczynań swoich ludzi przy ataku na wroga.",
                            ImagePath = "commandos.jpg",
                            Price = 10.99m,
                            SubGenreId = 5,
                            Title = "Commandos"
                        },
                        new
                        {
                            GameId = 6,
                            GameDescription = "Frostpunk jest połączeniem strategii czasu rzeczywistego i city buildera, wzbogaconym o wyraźnie zarysowane elementy survivalowe (twórcy mówią wręcz o opracowaniu nowego gatunku, nazwanego przez nich „society survival”). Za produkcję odpowiada polski zespół 11 bit studios, który zdobył światową sławę dzięki ciepło przyjętym grom z serii Anomaly oraz bestsellerowemu This War of Mine. Produkcja została wydana wyłącznie na platformie PC.",
                            ImagePath = "frostpunk.jpg",
                            Price = 44.99m,
                            SubGenreId = 4,
                            Title = "Frostpunk"
                        },
                        new
                        {
                            GameId = 7,
                            GameDescription = "World of WarCraft to pozycja, która należy do gatunku cRPG. Przygotowana została specjalnie z myślą o rozgrywce w trybie massive online multiplayer, gdzie w szranki stanąć może tysiące graczy z całego świata. Gra przenosi nas do starganego różnymi wojnami i zniszczeniem fantastycznego świata Azeroth - znanego z serii WarCraft.",
                            ImagePath = "wow.jpg",
                            Price = 90.99m,
                            SubGenreId = 3,
                            Title = "World Of Warcraft"
                        },
                        new
                        {
                            GameId = 8,
                            GameDescription = "Poprzednia, piąta odsłona marki była swoistym restartem serii, upraszczającym wiele elementów, które mogliśmy znaleźć w poprzedniczkach, w związku z czym na starcie brakowało w niej licznych aspektów rozgrywki z wcześniejszych Cywilizacji. W przypadku szóstej części cyklu twórcy nie chcieli popełniać tego samego błędu, więc większość nowości wprowadzonych przez piątkę i jej dodatki na podstawie sugestii graczy znalazła miejsce także w „podstawce” Sid Meier’s Civilization VI. ",
                            ImagePath = "civ.jpg",
                            Price = 52.99m,
                            SubGenreId = 6,
                            Title = "Sid Meier's Civilization VI"
                        },
                        new
                        {
                            GameId = 9,
                            GameDescription = "Farming Simulator 19 jest kolejną odsłoną znanego cyklu symulatorów, w których wcielamy się w rolnika. Gra oferuje dwie duże, otwarte i pełne różnego rodzaju zadań lokacje oraz setki maszyn i pojazdów, które możemy wykorzystać przy pracy. Za stworzenie omawianej produkcji odpowiada niezmiennie studio GIANTS Software.",
                            ImagePath = "farming.jpg",
                            Price = 78.99m,
                            SubGenreId = 7,
                            Title = "Farming Simulator 19"
                        },
                        new
                        {
                            GameId = 10,
                            GameDescription = "Green Hell jest grą survivalową, opracowaną przez niezależny polski zespół Creepy Jar; w jego skład wchodzą osoby, które wcześniej pracowały między innymi nad Dying Light oraz grami z serii Dead Island.W trakcie zabawy w Green Hell wcielamy się w nieszczęśnika pozostawionego na pastwę losu w amazońskiej dżungli. Chcąc ujść z życiem, bohater (początkowo wyposażony jedynie w radio, z którego przemawia do niego ukochana) musi od podstaw nauczyć się sztuki przetrwania.",
                            ImagePath = "greenhell.jpg",
                            Price = 85.99m,
                            SubGenreId = 7,
                            Title = "Green Hell"
                        },
                        new
                        {
                            GameId = 11,
                            GameDescription = "Euro Truck Simulator 2 to druga odsłona symulatora od SCS Software, w którym zasiadamy za sterami potężnych samochodów ciężarowych. Tytuł wprowadza szereg usprawnień w stosunku do poprzedniczki, które miały za zadanie urealnić rozgrywkę. Dla fanów tego typu pozycji cenną informacją powinien być fakt, że za grę odpowiadają między innymi ludzie pracujący wcześniej nad Hard Truck 18 Wheels of Steel – inną produkcją o tej tematyce.",
                            ImagePath = "eurotruck.jpg",
                            Price = 27.99m,
                            SubGenreId = 7,
                            Title = "Euro Truck Simulator 2"
                        },
                        new
                        {
                            GameId = 12,
                            GameDescription = "Czwarta część The Sims, podobnie jak poprzedniczki unika rewolucyjnych zmian w modelu rozgrywki stawiając na powolną ewolucję sprawdzonych rozwiązań. W trakcie gry nadal opiekujemy się więc rodziną wirtualnych Simów dbając o ich wszystkie potrzeby, zarówno duchowe jak i materialne, a także zapewniając dach nad głową, projektując dom oraz ogród.",
                            ImagePath = "sims4.jpg",
                            Price = 55.99m,
                            SubGenreId = 7,
                            Title = "The Sims 4"
                        });
                });

            modelBuilder.Entity("JaskiniaGier.Models.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "Fabularne"
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "Przygodowe"
                        },
                        new
                        {
                            GenreId = 3,
                            GenreName = "Strategiczne"
                        },
                        new
                        {
                            GenreId = 4,
                            GenreName = "Symulacyjne"
                        });
                });

            modelBuilder.Entity("JaskiniaGier.Models.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShipAddressId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("GameId");

                    b.HasIndex("ShipAddressId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("JaskiniaGier.Models.Entities.ShipAddress", b =>
                {
                    b.Property<int>("ShipAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShipAddressId");

                    b.ToTable("ShipAddresses");
                });

            modelBuilder.Entity("JaskiniaGier.Models.Entities.SubGenre", b =>
                {
                    b.Property<int>("SubGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("SubGenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubGenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("SubGenres");

                    b.HasData(
                        new
                        {
                            SubGenreId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            SubGenreId = 2,
                            GenreId = 1,
                            SubGenreName = "Hack & Slash"
                        },
                        new
                        {
                            SubGenreId = 3,
                            GenreId = 1,
                            SubGenreName = "MMORPG"
                        },
                        new
                        {
                            SubGenreId = 4,
                            GenreId = 3,
                            SubGenreName = "RTS"
                        },
                        new
                        {
                            SubGenreId = 5,
                            GenreId = 3,
                            SubGenreName = "Taktyczne"
                        },
                        new
                        {
                            SubGenreId = 6,
                            GenreId = 3,
                            SubGenreName = "Ekonomiczne"
                        },
                        new
                        {
                            SubGenreId = 7,
                            GenreId = 4
                        });
                });

            modelBuilder.Entity("JaskiniaGier.Models.CartItem", b =>
                {
                    b.HasOne("JaskiniaGier.Models.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("JaskiniaGier.Models.Entities.Game", b =>
                {
                    b.HasOne("JaskiniaGier.Models.Entities.SubGenre", "SubGenre")
                        .WithMany()
                        .HasForeignKey("SubGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JaskiniaGier.Models.Entities.Order", b =>
                {
                    b.HasOne("JaskiniaGier.Models.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JaskiniaGier.Models.Entities.ShipAddress", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("ShipAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JaskiniaGier.Models.Entities.SubGenre", b =>
                {
                    b.HasOne("JaskiniaGier.Models.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
