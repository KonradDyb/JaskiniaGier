using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class IdentityUserFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "ShipAddresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdentityUserId",
                table: "ShipAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
