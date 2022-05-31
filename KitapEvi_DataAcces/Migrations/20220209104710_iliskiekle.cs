using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi_DataAcces.Migrations
{
    public partial class iliskiekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KitapYazarlar",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false),
                    YazarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazarlar", x => new { x.YazarID, x.KitapID });
                    table.ForeignKey(
                        name: "FK_KitapYazarlar_tb_Kitap_KitapID",
                        column: x => x.KitapID,
                        principalTable: "tb_Kitap",
                        principalColumn: "KitapID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazarlar_tb_Yazar_YazarID",
                        column: x => x.YazarID,
                        principalTable: "tb_Yazar",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_KitapDetay",
                columns: table => new
                {
                    KitapDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumSayisi = table.Column<int>(type: "int", nullable: false),
                    KitapSayfasi = table.Column<int>(type: "int", nullable: false),
                    Agirlik = table.Column<int>(type: "int", nullable: false),
                    KitapID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_KitapDetay", x => x.KitapDetayID);
                    table.ForeignKey(
                        name: "FK_tb_KitapDetay_tb_Kitap_KitapID",
                        column: x => x.KitapID,
                        principalTable: "tb_Kitap",
                        principalColumn: "KitapID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazarlar_KitapID",
                table: "KitapYazarlar",
                column: "KitapID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_KitapDetay_KitapID",
                table: "tb_KitapDetay",
                column: "KitapID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapYazarlar");

            migrationBuilder.DropTable(
                name: "tb_KitapDetay");
        }
    }
}
