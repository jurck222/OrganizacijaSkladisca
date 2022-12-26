using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    public partial class remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Article_ArticleID",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Warehouse_ArticleID",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "ArticleID",
                table: "Warehouse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleID",
                table: "Warehouse",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_ArticleID",
                table: "Warehouse",
                column: "ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Article_ArticleID",
                table: "Warehouse",
                column: "ArticleID",
                principalTable: "Article",
                principalColumn: "ArticleID");
        }
    }
}
