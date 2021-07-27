using Microsoft.EntityFrameworkCore.Migrations;

namespace RookieShop.Backend.Data.Migrations
{
    public partial class seedUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryDTO");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "688cc203-353c-4fb9-a309-b2decc46707a", "b62192c8-3a92-4f92-a98d-5d37c543d5a2", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6ec3ad1-8b6e-4e19-87b8-e863b55526bc", "3893b6ae-4a33-424e-938c-a43bf13c9bed", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4abead03-d561-44a3-8e59-af5243c7aebb", 0, "d7105a0d-0c43-4b3d-b771-169319d419bb", "admin@gmail.com", true, null, false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEMHHweI2JnsUPIA9Zwagk10qbN/jP6zy8fwVQZImhQdWdC7bnitkTnEUt5XF365sQA==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "688cc203-353c-4fb9-a309-b2decc46707a", "4abead03-d561-44a3-8e59-af5243c7aebb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6ec3ad1-8b6e-4e19-87b8-e863b55526bc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "688cc203-353c-4fb9-a309-b2decc46707a", "4abead03-d561-44a3-8e59-af5243c7aebb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "688cc203-353c-4fb9-a309-b2decc46707a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4abead03-d561-44a3-8e59-af5243c7aebb");

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
        }
    }
}
