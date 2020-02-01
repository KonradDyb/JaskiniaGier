using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class UpdateGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    CartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_GameId",
                table: "CartItems",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Price",
                value: "30,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Price",
                value: "100,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "Price",
                value: "12,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "Price",
                value: "30,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                column: "Price",
                value: "10,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                column: "Price",
                value: "44,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                column: "Price",
                value: "90,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                column: "Price",
                value: "52,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                column: "Price",
                value: "78,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                column: "Price",
                value: "85,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                column: "Price",
                value: "27,00 zł");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                column: "Price",
                value: "55,00 zł");
        }
    }
}
