using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInfoAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "EmployeeInformations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "EmployeeInformations");
        }
    }
}
