using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektBiblioteka.Migrations
{
    public partial class druga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ksiazki_Autorzy_AutorId",
                table: "Ksiazki");

            migrationBuilder.DropIndex(
                name: "IX_Ksiazki_AutorId",
                table: "Ksiazki");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Ksiazki");

            migrationBuilder.CreateTable(
                name: "AutorKsiazka",
                columns: table => new
                {
                    AutorzyAutorId = table.Column<int>(type: "int", nullable: false),
                    KsiazkiKsiazkaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorKsiazka", x => new { x.AutorzyAutorId, x.KsiazkiKsiazkaID });
                    table.ForeignKey(
                        name: "FK_AutorKsiazka_Autorzy_AutorzyAutorId",
                        column: x => x.AutorzyAutorId,
                        principalTable: "Autorzy",
                        principalColumn: "AutorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorKsiazka_Ksiazki_KsiazkiKsiazkaID",
                        column: x => x.KsiazkiKsiazkaID,
                        principalTable: "Ksiazki",
                        principalColumn: "KsiazkaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorKsiazka_KsiazkiKsiazkaID",
                table: "AutorKsiazka",
                column: "KsiazkiKsiazkaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorKsiazka");

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Ksiazki",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ksiazki_AutorId",
                table: "Ksiazki",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ksiazki_Autorzy_AutorId",
                table: "Ksiazki",
                column: "AutorId",
                principalTable: "Autorzy",
                principalColumn: "AutorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
