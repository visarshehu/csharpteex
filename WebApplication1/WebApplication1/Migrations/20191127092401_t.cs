using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<DateTime>(nullable: false),
                    FuelType = table.Column<string>(nullable: true),
                    LicensePlate = table.Column<string>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.LicensePlate);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    HasDriverLicense = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "RentedC",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    LicensePlate = table.Column<string>(nullable: false),
                    CarLicensePlate = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    DateofRent = table.Column<DateTime>(nullable: false),
                    DateofReurn = table.Column<DateTime>(nullable: false),
                    KMOnRent = table.Column<int>(nullable: false),
                    KMOnReturn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentedC", x => x.LicensePlate);
                    table.ForeignKey(
                        name: "FK_RentedC_Car_CarLicensePlate",
                        column: x => x.CarLicensePlate,
                        principalTable: "Car",
                        principalColumn: "LicensePlate",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RentedC_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentedC_CarLicensePlate",
                table: "RentedC",
                column: "CarLicensePlate");

            migrationBuilder.CreateIndex(
                name: "IX_RentedC_Username",
                table: "RentedC",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentedC");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
