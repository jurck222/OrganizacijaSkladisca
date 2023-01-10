using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    public partial class UpdateOrder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "zone",
                table: "Order",
                newName: "WhouseZone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WhouseZone",
                table: "Order",
                newName: "zone");
        }
    }
}
