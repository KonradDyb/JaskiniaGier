using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class UpdateGameDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 3,
                column: "GameDescription",
                value: "Akcja gry przenosi graczy do fantastycznego Królestwa Myrtany, którym rządzi król Rhobar II. Wcielając się w postać Bezimienngo trafiają oni do kolonii karnej na wyspie Khorinis. Otacza ją magiczna, przenikalna jedynie z zewnątrz bariera, którą stworzyli arcymagowie. Niestety, w trakcie inkantacji wydarzyło się coś niespodziewanego. Zasięg zaklęcia okazał się większy niż przewidywano i bariera otoczyła cały obszar Górniczej Doliny, więżąc także magów.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "GameDescription",
                value: "Akcja Diablo osadzona została w fantastycznym świecie Sanktuarium. Fabuła gry przedstawia zmagania z tytułowym Panem Terroru, który uwięziony w magicznym kamieniu dusz próbuje wydostać się z niewoli. Demon zdołał przeniknąć do umysłu arcybiskupa Lazarusa, prawej ręki władcy królestwa Khanduras. Następnie opętał króla Leorica, a z sennych koszmarów jego pierworodnego potomka stworzył armię przerażających kreatur krążących wokół miasteczka Tristram i pod jego powierzchnią. Nie bacząc na niebezpieczeństwo książę Aidan wyrusza, by stawić czoła siłom zła i pokonać Diablo.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                column: "GameDescription",
                value: "Commandos to taktyczna gra akcji rozgrywana w czasie rzeczywistym. Gra umiejscowiona jest w realiach II Wojny Światowej gdzie grupa komandosów, prowadzona przez gracza, ma do wykonania szereg trudnych misji za linią frontu. Powodzenie każdej z misji może zależeć od dokładnie przemyślanej strategii, zaplanowania każdego działania oraz zsynchronizowania poczynań swoich ludzi przy ataku na wroga.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                column: "GameDescription",
                value: "Frostpunk jest połączeniem strategii czasu rzeczywistego i city buildera, wzbogaconym o wyraźnie zarysowane elementy survivalowe (twórcy mówią wręcz o opracowaniu nowego gatunku, nazwanego przez nich „society survival”). Za produkcję odpowiada polski zespół 11 bit studios, który zdobył światową sławę dzięki ciepło przyjętym grom z serii Anomaly oraz bestsellerowemu This War of Mine. Produkcja została wydana wyłącznie na platformie PC.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                columns: new[] { "GameDescription", "Title" },
                values: new object[] { "Azeroth zapłacił ogromną cenę za niszczycielską krucjatę Płonącego Legionu, która została przedstawiona w poprzednim dodatku do gry. W chwili gdy świat powoli leczy rany zagrożeniem staje się rosnący brak zaufania pomiędzy Przymierzem i Hordą, które ponownie roznieca wrogość pomiędzy oboma stronnictwami. Jednym ze źródeł konfliktu jest do dostęp do nowego i cudownego magicznego minerału o Azerite. W trakcie zabawy gracze są świadkami tragicznych wydarzeń doprowadzających do kolejnej wojny oraz wytyczenia nowych granic, frontów i sojuszy, które zdecydują o przyszłości Azeroth.", "World Of Warcraft: Battle for Azeroth" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                column: "GameDescription",
                value: "Poprzednia, piąta odsłona marki była swoistym restartem serii, upraszczającym wiele elementów, które mogliśmy znaleźć w poprzedniczkach, w związku z czym na starcie brakowało w niej licznych aspektów rozgrywki z wcześniejszych Cywilizacji. W przypadku szóstej części cyklu twórcy nie chcieli popełniać tego samego błędu, więc większość nowości wprowadzonych przez piątkę i jej dodatki na podstawie sugestii graczy znalazła miejsce także w „podstawce” Sid Meier’s Civilization VI. ");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                column: "GameDescription",
                value: "Farming Simulator 19 jest kolejną odsłoną znanego cyklu symulatorów, w których wcielamy się w rolnika. Gra oferuje dwie duże, otwarte i pełne różnego rodzaju zadań lokacje oraz setki maszyn i pojazdów, które możemy wykorzystać przy pracy. Za stworzenie omawianej produkcji odpowiada niezmiennie studio GIANTS Software.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                column: "GameDescription",
                value: "Green Hell jest grą survivalową, opracowaną przez niezależny polski zespół Creepy Jar; w jego skład wchodzą osoby, które wcześniej pracowały między innymi nad Dying Light oraz grami z serii Dead Island.W trakcie zabawy w Green Hell wcielamy się w nieszczęśnika pozostawionego na pastwę losu w amazońskiej dżungli. Chcąc ujść z życiem, bohater (początkowo wyposażony jedynie w radio, z którego przemawia do niego ukochana) musi od podstaw nauczyć się sztuki przetrwania.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                column: "GameDescription",
                value: "Euro Truck Simulator 2 to druga odsłona symulatora od SCS Software, w którym zasiadamy za sterami potężnych samochodów ciężarowych. Tytuł wprowadza szereg usprawnień w stosunku do poprzedniczki, które miały za zadanie urealnić rozgrywkę. Dla fanów tego typu pozycji cenną informacją powinien być fakt, że za grę odpowiadają między innymi ludzie pracujący wcześniej nad Hard Truck 18 Wheels of Steel – inną produkcją o tej tematyce.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                column: "GameDescription",
                value: "Czwarta część The Sims, podobnie jak poprzedniczki unika rewolucyjnych zmian w modelu rozgrywki stawiając na powolną ewolucję sprawdzonych rozwiązań. W trakcie gry nadal opiekujemy się więc rodziną wirtualnych Simów dbając o ich wszystkie potrzeby, zarówno duchowe jak i materialne, a także zapewniając dach nad głową, projektując dom oraz ogród.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "GameDescription",
                value: "Strategia ekonomiczna od Ubisoftu");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "GameDescription",
                value: "RPG od Piranha Bytes");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "GameDescription",
                value: "Hack&Slash od Blizzarda");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                column: "GameDescription",
                value: "Strategia taktyczna od Pyro Studios");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                column: "GameDescription",
                value: "Strategia RTS od 11 Bit Studios");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                columns: new[] { "GameDescription", "Title" },
                values: new object[] { "Rozszerzenie do WoWa", "World Of Warcraft" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                column: "GameDescription",
                value: "Strategia Ekonomiczna od Firaxis Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                column: "GameDescription",
                value: "Symulator rolina od GIANTS Software");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                column: "GameDescription",
                value: "Symulator survivalu od Creepy Jar");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                column: "GameDescription",
                value: "Symulator jazdy ciężarówką od SCS Software");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                column: "GameDescription",
                value: "Cykl symulacji życia od EA Maxis / Maxis Software");
        }
    }
}
