using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    public partial class OrdersFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarehouseID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Zone",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_WarehouseID",
                table: "Order",
                column: "WarehouseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Warehouse_WarehouseID",
                table: "Order",
                column: "WarehouseID",
                principalTable: "Warehouse",
                principalColumn: "WarehouseID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Warehouse_WarehouseID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_WarehouseID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "WarehouseID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Zone",
                table: "Order");
        }
    }
}
