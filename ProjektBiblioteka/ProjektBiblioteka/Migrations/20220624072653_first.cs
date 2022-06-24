using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektBiblioteka.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autorzy",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imie = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    Nazwisko = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autorzy", x => x.AutorId);
                });

            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    KategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.KategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Uzytkownicy",
                columns: table => new
                {
                    UzytkownikId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Haslo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzytkownicy", x => x.UzytkownikId);
                });

            migrationBuilder.CreateTable(
                name: "Ksiazki",
                columns: table => new
                {
                    KsiazkaID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    Opis = table.Column<string>(type: "TEXT", nullable: true),
                    Ocena = table.Column<double>(type: "REAL", nullable: false),
                    Ilosc = table.Column<int>(type: "INTEGER", nullable: false),
                    UzytkownikId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ksiazki", x => x.KsiazkaID);
                    table.ForeignKey(
                        name: "FK_Ksiazki_Uzytkownicy_UzytkownikId",
                        column: x => x.UzytkownikId,
                        principalTable: "Uzytkownicy",
                        principalColumn: "UzytkownikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AutorKsiazka",
                columns: table => new
                {
                    AutorzyAutorId = table.Column<int>(type: "INTEGER", nullable: false),
                    KsiazkiKsiazkaID = table.Column<int>(type: "INTEGER", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "KategoriaKsiazka",
                columns: table => new
                {
                    KategorieKategoriaId = table.Column<int>(type: "INTEGER", nullable: false),
                    KsiazkiKsiazkaID = table.Column<int>(type: "INTEGER", nullable: false)
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
                name: "IX_AutorKsiazka_KsiazkiKsiazkaID",
                table: "AutorKsiazka",
                column: "KsiazkiKsiazkaID");

            migrationBuilder.CreateIndex(
                name: "IX_KategoriaKsiazka_KsiazkiKsiazkaID",
                table: "KategoriaKsiazka",
                column: "KsiazkiKsiazkaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ksiazki_UzytkownikId",
                table: "Ksiazki",
                column: "UzytkownikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorKsiazka");

            migrationBuilder.DropTable(
                name: "KategoriaKsiazka");

            migrationBuilder.DropTable(
                name: "Autorzy");

            migrationBuilder.DropTable(
                name: "Kategorie");

            migrationBuilder.DropTable(
                name: "Ksiazki");

            migrationBuilder.DropTable(
                name: "Uzytkownicy");
        }
    }
}
