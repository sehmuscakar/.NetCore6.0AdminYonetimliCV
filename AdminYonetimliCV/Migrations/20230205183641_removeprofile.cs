using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminYonetimliCV.Migrations
{
    /// <inheritdoc />
    public partial class removeprofile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profil",
                table: "Anasayfas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profil",
                table: "Anasayfas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
