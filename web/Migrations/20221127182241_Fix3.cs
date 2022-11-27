using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    public partial class Fix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skladisce_Izdelek_IzdelekID",
                table: "Skladisce");

            migrationBuilder.AlterColumn<int>(
                name: "IzdelekID",
                table: "Skladisce",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Skladisce",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Skladisce_Izdelek_IzdelekID",
                table: "Skladisce",
                column: "IzdelekID",
                principalTable: "Izdelek",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skladisce_Izdelek_IzdelekID",
                table: "Skladisce");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Skladisce");

            migrationBuilder.AlterColumn<int>(
                name: "IzdelekID",
                table: "Skladisce",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Skladisce_Izdelek_IzdelekID",
                table: "Skladisce",
                column: "IzdelekID",
                principalTable: "Izdelek",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
