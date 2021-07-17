using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RookieShop.Backend.Data.Migrations
{
    public partial class moreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description" },
                values: new object[] { 1, "Laptop", "For all laptop" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description" },
                values: new object[] { 2, "Mobile Phone", "For all phone" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description" },
                values: new object[] { 3, "Tablet", "For all tablet" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "Price", "ProductName" },
                values: new object[] { 2, "The phone i'm currently using", 500m, "Realme Phone" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageLink", "Price", "ProductName", "Quantity", "isDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop ASUS cân mọi thể loại game, tự tin đánh bại tất cả các dòng laptop ngang tầm giá", "", 2000m, "Laptop ASUS", 3, false },
                    { 16, 3, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestSeedData Product #1", "", 200m, "Some tablet #2", 0, false },
                    { 15, 3, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestSeedData Product #1", "", 200m, "Some tablet #1", 0, false },
                    { 14, 3, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestSeedData Product #1", "", 600m, "Samsung Tablet", 0, false },
                    { 13, 3, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestSeedData Product #1", "", 700m, "IPad", 0, false },
                    { 12, 2, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "China phone for normal using", "", 100m, "Some china phone #1", 3, false },
                    { 11, 2, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi phone for budget gamers", "", 200m, "XiaoMi Phone", 3, false },
                    { 9, 2, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestSeedData Product #1", "", 700m, "Samsung Phone", 0, false },
                    { 8, 2, new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "You can buy another charger for 50$", "", 1000m, "IPhèo mười hai Phlus", 3, false },
                    { 7, 2, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Best gaming phone for rich gamers", "", 1000m, "ROG Phone ASUS 144Hz", 3, false },
                    { 6, 1, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop cũ hàng dùng rồi số 3 dành cho người có ngân khố eo hẹp, giá thành hợp lí", "", 200m, "Laptop cũ hàng 2nd số 003", 3, false },
                    { 5, 1, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop cũ hàng dùng rồi số 2 dành cho người có ngân khố eo hẹp, giá thành hợp lí", "", 400m, "Laptop cũ hàng 2nd số 002", 3, false },
                    { 4, 1, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop cũ hàng dùng rồi số 1 dành cho người có ngân khố eo hẹp, giá thành hợp lí", "", 500m, "Laptop cũ hàng 2nd số 001", 3, false },
                    { 3, 1, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop trung quốc dành cho người có ngân khố eo hẹp, giá thành hợp lí", "", 700m, "Laptop trung quốc", 3, false },
                    { 2, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop Vivo phù hợp cho dân văn phòng, xem phim lướt web đánh LOL vô tư", "", 1000m, "Laptop Vivo", 3, false },
                    { 17, 3, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestSeedData Product #1", "", 200m, "Some tablet #3", 0, false },
                    { 18, 3, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestSeedData Product #1", "", 200m, "Some tablet #4", 0, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "Price", "ProductName" },
                values: new object[] { 1, "TestSeedData Product #1", 200m, "TestSeedData Product #1" });
        }
    }
}
