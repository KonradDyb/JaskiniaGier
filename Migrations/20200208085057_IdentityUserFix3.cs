using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class IdentityUserFix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "ShipAddresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "ShipAddresses",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
