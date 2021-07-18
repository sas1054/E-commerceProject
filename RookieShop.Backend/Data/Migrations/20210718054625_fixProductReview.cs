using Microsoft.EntityFrameworkCore.Migrations;

namespace RookieShop.Backend.Data.Migrations
{
    public partial class fixProductReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_ProductId1",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_ProductId1",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "ProductReviews");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductId",
                table: "ProductReviews",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_ProductId",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "ProductReviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "ProductReviews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductId1",
                table: "ProductReviews",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_ProductId1",
                table: "ProductReviews",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
