using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Berylilium.Migrations
{
    public partial class DeletedSomeColumsInBanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "banners");

            migrationBuilder.DropColumn(
                name: "Tittle",
                table: "banners");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "banners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tittle",
                table: "banners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
