﻿// <auto-generated />
using JaskiniaGier.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JaskiniaGier.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200129180111_FixOneGame")]
    partial class FixOneGame
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

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
                            Price = "30,00 zł",
                            SubGenreId = 1,
                            Title = "Wiedźmin 1"
                        },
                        new
                        {
                            GameId = 2,
                            GameDescription = "Strategia ekonomiczna od Ubisoftu",
                            ImagePath = "anno.jpg",
                            Price = "100,00 zł",
                            SubGenreId = 6,
                            Title = "Anno 1800"
                        },
                        new
                        {
                            GameId = 3,
                            GameDescription = "RPG od Piranha Bytes",
                            ImagePath = "gothic.jpg",
                            Price = "12,00 zł",
                            SubGenreId = 1,
                            Title = "Gothic"
                        },
                        new
                        {
                            GameId = 4,
                            GameDescription = "Hack&Slash od Blizzarda",
                            ImagePath = "diablo.jpg",
                            Price = "30,00 zł",
                            SubGenreId = 2,
                            Title = "Diablo"
                        },
                        new
                        {
                            GameId = 5,
                            GameDescription = "Strategia taktyczna od Pyro Studios",
                            ImagePath = "commandos.jpg",
                            Price = "10,00 zł",
                            SubGenreId = 5,
                            Title = "Commandos"
                        },
                        new
                        {
                            GameId = 6,
                            GameDescription = "Strategia RTS od 11 Bit Studios",
                            ImagePath = "frostpunk.jpg",
                            Price = "44,00 zł",
                            SubGenreId = 4,
                            Title = "Frostpunk"
                        },
                        new
                        {
                            GameId = 7,
                            GameDescription = "Rozszerzenie do WoWa",
                            ImagePath = "wow.jpg",
                            Price = "170,00 zł",
                            SubGenreId = 3,
                            Title = "World Of Warcraft"
                        },
                        new
                        {
                            GameId = 8,
                            GameDescription = "Strategia Ekonomiczna od Firaxis Games",
                            ImagePath = "civ.jpg",
                            Price = "52,00 zł",
                            SubGenreId = 6,
                            Title = "Sid Meier's Civilization VI"
                        },
                        new
                        {
                            GameId = 9,
                            GameDescription = "Symulator rolina od GIANTS Software",
                            ImagePath = "farming.jpg",
                            Price = "78,00 zł",
                            SubGenreId = 7,
                            Title = "Farming Simulator 19"
                        },
                        new
                        {
                            GameId = 10,
                            GameDescription = "Symulator survivalu od Creepy Jar",
                            ImagePath = "greenhell.jpg",
                            Price = "85,00 zł",
                            SubGenreId = 7,
                            Title = "Green Hell"
                        },
                        new
                        {
                            GameId = 11,
                            GameDescription = "Symulator jazdy ciężarówką od SCS Software",
                            ImagePath = "eurotruck.jpg",
                            Price = "27,00 zł",
                            SubGenreId = 7,
                            Title = "Euro Truck Simulator 2"
                        },
                        new
                        {
                            GameId = 12,
                            GameDescription = "Cykl symulacji życia od EA Maxis / Maxis Software",
                            ImagePath = "sims4.jpg",
                            Price = "55,00 zł",
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

            modelBuilder.Entity("JaskiniaGier.Models.Entities.Game", b =>
                {
                    b.HasOne("JaskiniaGier.Models.Entities.SubGenre", "SubGenre")
                        .WithMany()
                        .HasForeignKey("SubGenreId")
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