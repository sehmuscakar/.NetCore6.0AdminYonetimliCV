using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminYonetimliCV.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anasayfas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unvan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    acıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    iletisim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anasayfas", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anasayfas");
        }
    }
}
