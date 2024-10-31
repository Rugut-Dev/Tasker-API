using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskerAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSuperAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Users",
            columns: new[] { "Username", "Email", "Password", "Role", "CreatedAt" },
            values: new object[] {
                "superadmin", 
                "superadmin@example.com",
                BCrypt.Net.BCrypt.HashPassword("superadminPass@123"),
                "SuperAdmin",
                DateTime.UtcNow
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "superadmin@example.com"
            );
        }
    }
}
