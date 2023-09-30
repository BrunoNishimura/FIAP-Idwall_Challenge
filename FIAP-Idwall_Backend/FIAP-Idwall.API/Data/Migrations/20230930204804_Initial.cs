using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP_Idwall.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetDbFiapIdwalls",
                columns: table => new
                {
                    WantedId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Fullname = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nationality = table.Column<string>(type: "TEXT", nullable: true),
                    Details = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetDbFiapIdwalls", x => x.WantedId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetDbFiapIdwalls");
        }
    }
}
