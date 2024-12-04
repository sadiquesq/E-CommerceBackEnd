using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a1f5d5da-e94d-44f1-a8c3-b60f42101a01"),
                column: "Password",
                value: "$2a$11$1k4vP4wthI/Q0XqjAoncXO/dOCmTPkgmsTOCr4.T7obopQAs89a2y");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e5b7d7f4-23f5-4d5f-bd85-dba98b93723b"),
                column: "Password",
                value: "$2a$11$ar8AjC4E.5xuvF5egy9rq.jOjCbGtiIzV2nUd8hGTqwwhSyR4ZwM2");
        }
    }
}
