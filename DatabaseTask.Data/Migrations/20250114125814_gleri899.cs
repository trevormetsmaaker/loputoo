using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class gleri899 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.CreateTable(
                name: "galerii",
                columns: table => new
                {
                    Nimi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lahtiolek = table.Column<int>(type: "int", nullable: false),
                    Omanik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Töötajad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_galerii", x => x.Nimi);
                });

            migrationBuilder.CreateTable(
                name: "kleint",
                columns: table => new
                {
                    EesNimi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PereNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telnr = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kleint", x => x.EesNimi);
                });

            migrationBuilder.CreateTable(
                name: "kunstiteos",
                columns: table => new
                {
                    Nimi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hind = table.Column<int>(type: "int", nullable: false),
                    Tüüp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aasta = table.Column<int>(type: "int", nullable: false),
                    Paritolu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kunstiteos", x => x.Nimi);
                });

            migrationBuilder.CreateTable(
                name: "Kunstnik",
                columns: table => new
                {
                    EesNimi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PereNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telnr = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunstnik", x => x.EesNimi);
                });

            migrationBuilder.CreateTable(
                name: "maal",
                columns: table => new
                {
                    Nimi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hind = table.Column<int>(type: "int", nullable: false),
                    Tuup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aasta = table.Column<int>(type: "int", nullable: false),
                    Paritolu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maal", x => x.Nimi);
                });

            migrationBuilder.CreateTable(
                name: "omanik",
                columns: table => new
                {
                    EesNimi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PereNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telnr = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_omanik", x => x.EesNimi);
                });

            migrationBuilder.CreateTable(
                name: "skulptuur",
                columns: table => new
                {
                    Nimi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hind = table.Column<int>(type: "int", nullable: false),
                    Tüüp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aasta = table.Column<int>(type: "int", nullable: false),
                    Paritolu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skulptuur", x => x.Nimi);
                });

            migrationBuilder.CreateTable(
                name: "tootaja",
                columns: table => new
                {
                    EesNimi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PereNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telnr = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tootaja", x => x.EesNimi);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "galerii");

            migrationBuilder.DropTable(
                name: "kleint");

            migrationBuilder.DropTable(
                name: "kunstiteos");

            migrationBuilder.DropTable(
                name: "Kunstnik");

            migrationBuilder.DropTable(
                name: "maal");

            migrationBuilder.DropTable(
                name: "omanik");

            migrationBuilder.DropTable(
                name: "skulptuur");

            migrationBuilder.DropTable(
                name: "tootaja");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }
    }
}
