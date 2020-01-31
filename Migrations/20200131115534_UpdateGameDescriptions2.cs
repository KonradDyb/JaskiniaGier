using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class UpdateGameDescriptions2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "GameDescription",
                value: "Anno 1800 jest kolejną odsłoną popularnego cyklu strategii ekonomicznych, nad którą pieczę sprawuje należące do firmy Ubisoft studio Blue Byte. Jak sugeruje tytuł produkcji jej akcja została osadzona w czasach rewolucji przemysłowej – mowa o epoce doniosłych odkryć geograficznych i naukowych oraz wszechobecnej industrializacji.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                columns: new[] { "GameDescription", "Price", "Title" },
                values: new object[] { "World of WarCraft to pozycja, która należy do gatunku cRPG. Przygotowana została specjalnie z myślą o rozgrywce w trybie massive online multiplayer, gdzie w szranki stanąć może tysiące graczy z całego świata. Gra przenosi nas do starganego różnymi wojnami i zniszczeniem fantastycznego świata Azeroth - znanego z serii WarCraft.", "90,00 zł", "World Of Warcraft" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "GameDescription",
                value: "Anno 1800 jest kolejną odsłoną popularnego cyklu strategii ekonomicznych, nad którą pieczę sprawuje należące do firmy Ubisoft studio Blue Byte. Produkcja trafiła na platformę {PLAT}, a jak sugeruje tytuł jej akcja została osadzona w czasach rewolucji przemysłowej – mowa o epoce doniosłych odkryć geograficznych i naukowych oraz wszechobecnej industrializacji.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                columns: new[] { "GameDescription", "Price", "Title" },
                values: new object[] { "Azeroth zapłacił ogromną cenę za niszczycielską krucjatę Płonącego Legionu, która została przedstawiona w poprzednim dodatku do gry. W chwili gdy świat powoli leczy rany zagrożeniem staje się rosnący brak zaufania pomiędzy Przymierzem i Hordą, które ponownie roznieca wrogość pomiędzy oboma stronnictwami. Jednym ze źródeł konfliktu jest do dostęp do nowego i cudownego magicznego minerału o Azerite. W trakcie zabawy gracze są świadkami tragicznych wydarzeń doprowadzających do kolejnej wojny oraz wytyczenia nowych granic, frontów i sojuszy, które zdecydują o przyszłości Azeroth.", "170,00 zł", "World Of Warcraft: Battle for Azeroth" });
        }
    }
}
