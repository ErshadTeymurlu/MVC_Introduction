using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Berylilium.Migrations
{
    public partial class _BannerChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SliderTitle",
                table: "banners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SliderTitle",
                table: "banners");
        }
    }
}
