using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RookieShop.Backend.Data.Migrations
{
    public partial class test_dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryDTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDTO", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageLink", "Price", "ProductName", "Quantity", "isDeleted" },
                values: new object[] { 10, 1, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestSeedData Product #1", "", 200m, "TestSeedData Product #1", 0, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryDTO");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
