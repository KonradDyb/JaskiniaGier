using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class UpdateGamePrice2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Price",
                value: 30.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Price",
                value: 100.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "Price",
                value: 12.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "Price",
                value: 30.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                column: "Price",
                value: 10.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                column: "Price",
                value: 44.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                column: "Price",
                value: 90.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                column: "Price",
                value: 52.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                column: "Price",
                value: 78.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                column: "Price",
                value: 85.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                column: "Price",
                value: 27.99m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                column: "Price",
                value: 55.99m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Price",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "Price",
                value: 12m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "Price",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                column: "Price",
                value: 44m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                column: "Price",
                value: 90m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                column: "Price",
                value: 52m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                column: "Price",
                value: 78m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                column: "Price",
                value: 85m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                column: "Price",
                value: 27m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                column: "Price",
                value: 55m);
        }
    }
}
