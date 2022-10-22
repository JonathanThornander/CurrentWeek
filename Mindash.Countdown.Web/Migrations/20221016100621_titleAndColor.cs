using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mindash.Countdown.Web.Migrations
{
    public partial class titleAndColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HexColor",
                table: "Dates",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Dates",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HexColor",
                table: "Dates");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Dates");
        }
    }
}
