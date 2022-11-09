using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcLearning.Migrations
{
    /// <inheritdoc />
    public partial class dotnetExample5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personals_Departments_departmentId",
                table: "Personals");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Personals",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Personals_departmentId",
                table: "Personals",
                newName: "IX_Personals_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personals_Departments_DepartmentId",
                table: "Personals",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "departmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personals_Departments_DepartmentId",
                table: "Personals");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Personals",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Personals_DepartmentId",
                table: "Personals",
                newName: "IX_Personals_departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personals_Departments_departmentId",
                table: "Personals",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "departmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
