using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JaskiniaGier.Migrations
{
    public partial class ChangeShipAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShipAddresses_ShipAddressId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "ShipAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShipAddressId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipAddressId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address1 = table.Column<string>(maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(maxLength: 50, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 6, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 9, nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDetailsId",
                table: "Orders",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailsId",
                table: "Orders",
                column: "OrderDetailsId",
                principalTable: "OrderDetails",
                principalColumn: "OrderDetailsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailsId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderDetailsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ShipAddressId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ShipAddresses",
                columns: table => new
                {
                    ShipAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipAddresses", x => x.ShipAddressId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipAddressId",
                table: "Orders",
                column: "ShipAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShipAddresses_ShipAddressId",
                table: "Orders",
                column: "ShipAddressId",
                principalTable: "ShipAddresses",
                principalColumn: "ShipAddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
