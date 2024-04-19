using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Management.API.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2dbc1f52-70c0-486a-b186-5b1f1a584c21", "1", "Admin", "Admin" },
                    { "c5aa0337-0710-4cf4-9c11-933c89f773a4", "2", "User", "User" },
                    { "d2fbb2c5-3550-4614-b2f3-6bfa77fd0cc2", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dbc1f52-70c0-486a-b186-5b1f1a584c21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5aa0337-0710-4cf4-9c11-933c89f773a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2fbb2c5-3550-4614-b2f3-6bfa77fd0cc2");
        }
    }
}
