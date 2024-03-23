using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInfoAPI.Migrations
{
    /// <inheritdoc />
    public partial class RefactorProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "EmployeeInformations",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "EmployeeInformations");
        }
    }
}
