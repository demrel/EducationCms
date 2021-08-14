using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EducationCms.Data.Migrations
{
    public partial class Thirdmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileUrl",
                table: "FileShare",
                newName: "Url");

            migrationBuilder.AddColumn<bool>(
                name: "IsStared",
                table: "Consumers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SeminarId",
                table: "Consumers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Consulting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consulting_BasePost_Id",
                        column: x => x.Id,
                        principalTable: "BasePost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_SeminarId",
                table: "Consumers",
                column: "SeminarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumers_Seminar_SeminarId",
                table: "Consumers",
                column: "SeminarId",
                principalTable: "Seminar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumers_Seminar_SeminarId",
                table: "Consumers");

            migrationBuilder.DropTable(
                name: "Consulting");

            migrationBuilder.DropIndex(
                name: "IX_Consumers_SeminarId",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "IsStared",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "SeminarId",
                table: "Consumers");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "FileShare",
                newName: "FileUrl");
        }
    }
}
