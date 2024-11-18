using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class firsts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a1f5d5da-e94d-44f1-a8c3-b60f42101a01"),
                column: "Password",
                value: "$2a$11$.ebDw8fMMtFPAMZMtOycj.P8wPb279YMIWZnQW6qObjYq8rQRcT16");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e5b7d7f4-23f5-4d5f-bd85-dba98b93723b"),
                column: "Password",
                value: "$2a$11$86u0hts16vplPu4qVrILDOd2N6Z05UFoxsywNCH5qpagYny.PdmZu");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a1f5d5da-e94d-44f1-a8c3-b60f42101a01"),
                column: "Password",
                value: "$2a$11$HDbzORBWiXP9UJ9pVSnu7.5hc4dY4fNuh65lQqE9y2wi365wNH0xO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e5b7d7f4-23f5-4d5f-bd85-dba98b93723b"),
                column: "Password",
                value: "$2a$11$tRBuNgBw7PaKWLp/Ftrkcehh.yiINMnxWy2GA.wuR4m7U53g/VbZ.");
        }
    }
}
