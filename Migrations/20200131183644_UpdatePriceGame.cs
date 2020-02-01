using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class UpdatePriceGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Games",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Price",
                value: "30.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Price",
                value: "100.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "Price",
                value: "12.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "Price",
                value: "30.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                column: "Price",
                value: "10.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                column: "Price",
                value: "44.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                column: "Price",
                value: "90.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                column: "Price",
                value: "52.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                column: "Price",
                value: "78.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                column: "Price",
                value: "85.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                column: "Price",
                value: "27.00");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                column: "Price",
                value: "55.00");
        }
    }
}
