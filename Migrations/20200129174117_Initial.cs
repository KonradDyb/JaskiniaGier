using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "SubGenres",
                columns: table => new
                {
                    SubGenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubGenreName = table.Column<string>(nullable: true),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubGenres", x => x.SubGenreId);
                    table.ForeignKey(
                        name: "FK_SubGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    GameDescription = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    SubGenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_SubGenres_SubGenreId",
                        column: x => x.SubGenreId,
                        principalTable: "SubGenres",
                        principalColumn: "SubGenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[,]
                {
                    { 1, "Fabularne" },
                    { 2, "Przygodowe" },
                    { 3, "Strategiczne" },
                    { 4, "Symulacyjne" }
                });

            migrationBuilder.InsertData(
                table: "SubGenres",
                columns: new[] { "SubGenreId", "GenreId", "SubGenreName" },
                values: new object[,]
                {
                    { 1, 1, null },
                    { 2, 1, "Hack & Slash" },
                    { 3, 1, "MMORPG" },
                    { 4, 3, "RTS" },
                    { 5, 3, "Taktyczne" },
                    { 6, 3, "Ekonomiczne" },
                    { 7, 4, null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "GameDescription", "ImagePath", "Price", "SubGenreId", "Title" },
                values: new object[,]
                {
                    { 1, "Nazywasz się Geralt z Rivii i jesteś wiedźminem, czyli za pieniądze zabijasz potwory. Przeszedłeś specjalne szkolenie, aby być najlepszym w swoim fachu, a twoje ciało zostało wzmocnione silnymi eliksirami. Masz amnezję i nie pamiętasz swojej przeszłości. Kaer Morhen, ostatnia twierdza wiedźminów, zostało zaatakowane przez tajemniczą organizację, gdy zaczynałeś leczyć tam swoje rany. Wygraliście bitwę, lecz straciliście sekretny przepis na mutagen - substancję potrzebną do tworzenia wiedźminów. Ci z twoich braci, którzy ocaleli, wyruszają, aby go odnaleźć i ukarać winnych. Pamiętasz czy nie, jesteś teraz jednym z nich.", "wiedzmin.jpg", "30,00 zł", 1, "Wiedźmin 1" },
                    { 3, "RPG od Piranha Bytes", "gothic.jpg", "12,00 zł", 1, "Gothic" },
                    { 4, "Hack&Slash od Blizzarda", "diablo.jpg", "30,00 zł", 1, "Diablo" },
                    { 7, "Rozszerzenie do WoWa", "wow.jpg", "170,00 zł", 3, "World Of Warcraft" },
                    { 6, "Strategia RTS od 11 Bit Studios", "frostpunk.jpg", "44,00 zł", 4, "Frostpunk" },
                    { 5, "Strategia taktyczna od Pyro Studios", "commandos.jpg", "10,00 zł", 5, "Commandos" },
                    { 2, "Strategia ekonomiczna od Ubisoftu", "anno.jpg", "100,00 zł", 6, "Anno 1800" },
                    { 8, "Strategia Ekonomiczna od Firaxis Games", "civ.jpg", "52,00 zł", 6, "Sid Meier's Civilization VI" },
                    { 9, "Symulator rolina od GIANTS Software", "farming.jpg", "78,00 zł", 7, "Farming Simulator 19" },
                    { 10, "Symulator survivalu od Creepy Jar", "greenhell.jpg", "85,00 zł", 7, "Green Hell" },
                    { 11, "Symulator jazdy ciężarówką od SCS Software", "eurotruck.jpg", "27,00 zł", 7, "Euro Truck Simulator 2" },
                    { 12, "Cykl symulacji życia od EA Maxis / Maxis Software", "sims4.jpg", "55,00 zł", 7, "The Sims 4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_SubGenreId",
                table: "Games",
                column: "SubGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_SubGenres_GenreId",
                table: "SubGenres",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "SubGenres");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
