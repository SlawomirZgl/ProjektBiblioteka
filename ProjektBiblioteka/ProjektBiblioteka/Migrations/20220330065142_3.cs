using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektBiblioteka.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategorie_Ksiazki_KsiazkaID",
                table: "Kategorie");

            migrationBuilder.DropIndex(
                name: "IX_Kategorie_KsiazkaID",
                table: "Kategorie");

            migrationBuilder.DropColumn(
                name: "KsiazkaID",
                table: "Kategorie");

            migrationBuilder.CreateTable(
                name: "KategoriaKsiazka",
                columns: table => new
                {
                    KategorieKategoriaId = table.Column<int>(type: "int", nullable: false),
                    KsiazkiKsiazkaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriaKsiazka", x => new { x.KategorieKategoriaId, x.KsiazkiKsiazkaID });
                    table.ForeignKey(
                        name: "FK_KategoriaKsiazka_Kategorie_KategorieKategoriaId",
                        column: x => x.KategorieKategoriaId,
                        principalTable: "Kategorie",
                        principalColumn: "KategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriaKsiazka_Ksiazki_KsiazkiKsiazkaID",
                        column: x => x.KsiazkiKsiazkaID,
                        principalTable: "Ksiazki",
                        principalColumn: "KsiazkaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KategoriaKsiazka_KsiazkiKsiazkaID",
                table: "KategoriaKsiazka",
                column: "KsiazkiKsiazkaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KategoriaKsiazka");

            migrationBuilder.AddColumn<int>(
                name: "KsiazkaID",
                table: "Kategorie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategorie_KsiazkaID",
                table: "Kategorie",
                column: "KsiazkaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategorie_Ksiazki_KsiazkaID",
                table: "Kategorie",
                column: "KsiazkaID",
                principalTable: "Ksiazki",
                principalColumn: "KsiazkaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
