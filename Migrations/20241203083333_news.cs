using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class news : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a1f5d5da-e94d-44f1-a8c3-b60f42101a01"),
                column: "Password",
                value: "$2a$11$xATqaeDFdXgFn2pW1sHtu.5A3pLCDSEVFQn6sZBH8KpEZbXXNA0eW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e5b7d7f4-23f5-4d5f-bd85-dba98b93723b"),
                column: "Password",
                value: "$2a$11$HAXArI6aW2sWAqt6VPl58u1mKU8.EbxOJNKQHqD5IocVvscfoYfGK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a1f5d5da-e94d-44f1-a8c3-b60f42101a01"),
                column: "Password",
                value: "$2a$11$kW.1yERkoyEjjKnqI2Lse.ggQXDLQagn8Zb1Pymtmb6Da1qn8QDAK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e5b7d7f4-23f5-4d5f-bd85-dba98b93723b"),
                column: "Password",
                value: "$2a$11$7mxTX6kmIamohkRSYvxydOfDxsWZIvMNlCGdKCW5.vGyyg1x6PwQa");
        }
    }
}
