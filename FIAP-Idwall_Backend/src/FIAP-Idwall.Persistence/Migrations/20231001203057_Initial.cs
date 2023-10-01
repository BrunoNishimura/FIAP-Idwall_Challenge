using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP_Idwall.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FiapIdwalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Fullname = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nationality = table.Column<string>(type: "TEXT", nullable: true),
                    Details = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiapIdwalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelFbis",
                columns: table => new
                {
                    FbiId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FbiPictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    FbiFullname = table.Column<string>(type: "TEXT", nullable: true),
                    FbiDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FbiDetails = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelFbis", x => x.FbiId);
                });

            migrationBuilder.CreateTable(
                name: "ModelInterpols",
                columns: table => new
                {
                    InterpolId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InterpolPictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    InterpolFullname = table.Column<string>(type: "TEXT", nullable: true),
                    InterpolDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InterpolNationality = table.Column<string>(type: "TEXT", nullable: true),
                    InterpolDetails = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelInterpols", x => x.InterpolId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FiapIdwalls");

            migrationBuilder.DropTable(
                name: "ModelFbis");

            migrationBuilder.DropTable(
                name: "ModelInterpols");
        }
    }
}
