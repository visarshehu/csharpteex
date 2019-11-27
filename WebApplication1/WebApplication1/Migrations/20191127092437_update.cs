using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestModels");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    DateOfOrder = table.Column<DateTime>(nullable: false),
                    Bid = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.DateOfOrder);
                    table.ForeignKey(
                        name: "FK_Orders_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cybertrucks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    EstimatedDelivery = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    OrderDateOfOrder = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cybertrucks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cybertrucks_Orders_OrderDateOfOrder",
                        column: x => x.OrderDateOfOrder,
                        principalTable: "Orders",
                        principalColumn: "DateOfOrder",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cybertrucks_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cybertrucks_OrderDateOfOrder",
                table: "Cybertrucks",
                column: "OrderDateOfOrder");

            migrationBuilder.CreateIndex(
                name: "IX_Cybertrucks_Username",
                table: "Cybertrucks",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Username",
                table: "Orders",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cybertrucks");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "TestModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    test = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestModels", x => x.Id);
                });
        }
    }
}
