using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test_task_deliver_RyndychRD.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sender_city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sender_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    receiver_city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    receiver_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    package_weight = table.Column<int>(type: "int", nullable: false),
                    package_pickupDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");
        }
    }
}
