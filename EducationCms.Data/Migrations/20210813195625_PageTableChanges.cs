using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationCms.Data.Migrations
{
    public partial class PageTableChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Percent1",
                table: "TizerVideoPlaces",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Percent2",
                table: "TizerVideoPlaces",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Value1",
                table: "TizerVideoPlaces",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value2",
                table: "TizerVideoPlaces",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "Pages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Pages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title4",
                table: "Pages",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percent1",
                table: "TizerVideoPlaces");

            migrationBuilder.DropColumn(
                name: "Percent2",
                table: "TizerVideoPlaces");

            migrationBuilder.DropColumn(
                name: "Value1",
                table: "TizerVideoPlaces");

            migrationBuilder.DropColumn(
                name: "Value2",
                table: "TizerVideoPlaces");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Title4",
                table: "Pages");
        }
    }
}
