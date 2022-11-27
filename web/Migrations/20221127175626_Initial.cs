using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Izdelek",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Sifra = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izdelek", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Skladisce",
                columns: table => new
                {
                    SkladisceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cona = table.Column<int>(type: "int", nullable: false),
                    IzdelekID = table.Column<int>(type: "int", nullable: false),
                    Zasedeno = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladisce", x => x.SkladisceId);
                    table.ForeignKey(
                        name: "FK_Skladisce_Izdelek_IzdelekID",
                        column: x => x.IzdelekID,
                        principalTable: "Izdelek",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skladisce_IzdelekID",
                table: "Skladisce",
                column: "IzdelekID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skladisce");

            migrationBuilder.DropTable(
                name: "Izdelek");
        }
    }
}
