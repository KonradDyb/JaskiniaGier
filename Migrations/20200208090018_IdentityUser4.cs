using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class IdentityUser4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShipAddresses_AspNetUsers_UserId",
                table: "ShipAddresses");

            migrationBuilder.DropIndex(
                name: "IX_ShipAddresses_UserId",
                table: "ShipAddresses");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ShipAddresses",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ShipAddresses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShipAddresses_UserId",
                table: "ShipAddresses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShipAddresses_AspNetUsers_UserId",
                table: "ShipAddresses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
