using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class firstss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WhishList",
                columns: table => new
                {
                    WhishlistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhishList", x => x.WhishlistId);
                    table.ForeignKey(
                        name: "FK_WhishList_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a1f5d5da-e94d-44f1-a8c3-b60f42101a01"),
                column: "Password",
                value: "$2a$11$HDBairuw5xeOq1MZb6YWieWiU8vaRS1v9z6ljsBiKtFGsQUIjzZgS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e5b7d7f4-23f5-4d5f-bd85-dba98b93723b"),
                column: "Password",
                value: "$2a$11$uBR0JwT/4f8bm/kSTYRt8uI2wjJgzZctoMBhXFlbcQHAQLLOzF4zu");

            migrationBuilder.CreateIndex(
                name: "IX_WhishList_UserId",
                table: "WhishList",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WhishList");

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
        }
    }
}
