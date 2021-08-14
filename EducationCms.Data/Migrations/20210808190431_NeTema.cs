using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EducationCms.Data.Migrations
{
    public partial class NeTema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Banners",
                newName: "TitleSecond");

            migrationBuilder.AddColumn<bool>(
                name: "IsStared",
                table: "Pages",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Consumers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleFirst",
                table: "Banners",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MissionVisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageId = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionVisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MissionVisions_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Facebook = table.Column<string>(type: "text", nullable: true),
                    Youtube = table.Column<string>(type: "text", nullable: true),
                    Instagram = table.Column<string>(type: "text", nullable: true),
                    Twitter = table.Column<string>(type: "text", nullable: true),
                    BuisnesStartTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    ContactTitle = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TizerVideoPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    DescriptionFirst = table.Column<string>(type: "text", nullable: true),
                    DescriptionSecond = table.Column<string>(type: "text", nullable: true),
                    ContactText = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    VideoUrl = table.Column<string>(type: "text", nullable: true),
                    ImageSquareId = table.Column<int>(type: "integer", nullable: false),
                    ImageRectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TizerVideoPlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TizerVideoPlaces_Images_ImageRectId",
                        column: x => x.ImageRectId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TizerVideoPlaces_Images_ImageSquareId",
                        column: x => x.ImageSquareId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_ImageId",
                table: "Consumers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_MissionVisions_ImageId",
                table: "MissionVisions",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_TizerVideoPlaces_ImageRectId",
                table: "TizerVideoPlaces",
                column: "ImageRectId");

            migrationBuilder.CreateIndex(
                name: "IX_TizerVideoPlaces_ImageSquareId",
                table: "TizerVideoPlaces",
                column: "ImageSquareId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumers_Images_ImageId",
                table: "Consumers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumers_Images_ImageId",
                table: "Consumers");

            migrationBuilder.DropTable(
                name: "MissionVisions");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "TizerVideoPlaces");

            migrationBuilder.DropIndex(
                name: "IX_Consumers_ImageId",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "IsStared",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "TitleFirst",
                table: "Banners");

            migrationBuilder.RenameColumn(
                name: "TitleSecond",
                table: "Banners",
                newName: "Title");
        }
    }
}
