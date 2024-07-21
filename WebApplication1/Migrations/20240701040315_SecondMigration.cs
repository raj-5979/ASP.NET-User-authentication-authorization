using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5639cbb1-52a0-4ae4-b92a-abd6d268ea81", null, "seller", "seller" },
                    { "91ff6e98-7fdd-47dd-91fd-04f5de3b52f4", null, "client", "client" },
                    { "e2f60ebd-5bdb-4a55-ab6a-6105969cccc3", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5639cbb1-52a0-4ae4-b92a-abd6d268ea81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91ff6e98-7fdd-47dd-91fd-04f5de3b52f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2f60ebd-5bdb-4a55-ab6a-6105969cccc3");
        }
    }
}
