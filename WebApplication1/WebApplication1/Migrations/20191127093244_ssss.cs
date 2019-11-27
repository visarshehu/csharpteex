using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class ssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CyberTruck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    EstimatedDelivery = table.Column<int>(nullable: false),
                    OrderBid = table.Column<int>(nullable: true),
                    OrderBid1 = table.Column<int>(nullable: true),
                    OrderBid2 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CyberTruck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CyberTruck_Order_OrderBid",
                        column: x => x.OrderBid,
                        principalTable: "Order",
                        principalColumn: "Bid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberTruck_Order_OrderBid1",
                        column: x => x.OrderBid1,
                        principalTable: "Order",
                        principalColumn: "Bid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberTruck_Order_OrderBid2",
                        column: x => x.OrderBid2,
                        principalTable: "Order",
                        principalColumn: "Bid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CyberTruck_OrderBid",
                table: "CyberTruck",
                column: "OrderBid");

            migrationBuilder.CreateIndex(
                name: "IX_CyberTruck_OrderBid1",
                table: "CyberTruck",
                column: "OrderBid1");

            migrationBuilder.CreateIndex(
                name: "IX_CyberTruck_OrderBid2",
                table: "CyberTruck",
                column: "OrderBid2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CyberTruck");
        }
    }
}
