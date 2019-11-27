using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class exam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Manufacturer = table.Column<string>(maxLength: 2, nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    FuelType = table.Column<string>(nullable: true),
                    LicencePlate = table.Column<string>(nullable: false),
                    DateRegistered = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.LicencePlate);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    HasDriverLicence = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Username);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
