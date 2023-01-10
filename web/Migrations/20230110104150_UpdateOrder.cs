using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    public partial class UpdateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Article_ArticleID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ArticleID",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Order",
                newName: "zone");

            migrationBuilder.RenameColumn(
                name: "ArticleID",
                table: "Order",
                newName: "ArticleCode");

            migrationBuilder.AddColumn<string>(
                name: "OrderCode",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WarehouseName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "WarehouseName",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "zone",
                table: "Order",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "ArticleCode",
                table: "Order",
                newName: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ArticleID",
                table: "Order",
                column: "ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Article_ArticleID",
                table: "Order",
                column: "ArticleID",
                principalTable: "Article",
                principalColumn: "ArticleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
