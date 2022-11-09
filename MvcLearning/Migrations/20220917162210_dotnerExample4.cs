using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcLearning.Migrations
{
    /// <inheritdoc />
    public partial class dotnerExample4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Departments",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Departments");
        }
    }
}
