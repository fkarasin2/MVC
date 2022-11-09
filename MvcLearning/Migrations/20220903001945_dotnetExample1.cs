using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcLearning.Migrations
{
    /// <inheritdoc />
    public partial class dotnetExample1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currrents_SalesMovements_salesMovementId",
                table: "Currrents");

            migrationBuilder.DropForeignKey(
                name: "FK_Personals_SalesMovements_salesMovementId",
                table: "Personals");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SalesMovements_salesMovementId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_salesMovementId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Personals_salesMovementId",
                table: "Personals");

            migrationBuilder.DropIndex(
                name: "IX_Currrents_salesMovementId",
                table: "Currrents");

            migrationBuilder.DropColumn(
                name: "salesMovementId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "salesMovementId",
                table: "Personals");

            migrationBuilder.DropColumn(
                name: "salesMovementId",
                table: "Currrents");

            migrationBuilder.AddColumn<int>(
                name: "CurrrentcurrentId",
                table: "SalesMovements",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "personalId",
                table: "SalesMovements",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "SalesMovements",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SalesMovements_CurrrentcurrentId",
                table: "SalesMovements",
                column: "CurrrentcurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesMovements_personalId",
                table: "SalesMovements",
                column: "personalId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesMovements_productId",
                table: "SalesMovements",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesMovements_Currrents_CurrrentcurrentId",
                table: "SalesMovements",
                column: "CurrrentcurrentId",
                principalTable: "Currrents",
                principalColumn: "currentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesMovements_Personals_personalId",
                table: "SalesMovements",
                column: "personalId",
                principalTable: "Personals",
                principalColumn: "personalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesMovements_Products_productId",
                table: "SalesMovements",
                column: "productId",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesMovements_Currrents_CurrrentcurrentId",
                table: "SalesMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesMovements_Personals_personalId",
                table: "SalesMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesMovements_Products_productId",
                table: "SalesMovements");

            migrationBuilder.DropIndex(
                name: "IX_SalesMovements_CurrrentcurrentId",
                table: "SalesMovements");

            migrationBuilder.DropIndex(
                name: "IX_SalesMovements_personalId",
                table: "SalesMovements");

            migrationBuilder.DropIndex(
                name: "IX_SalesMovements_productId",
                table: "SalesMovements");

            migrationBuilder.DropColumn(
                name: "CurrrentcurrentId",
                table: "SalesMovements");

            migrationBuilder.DropColumn(
                name: "personalId",
                table: "SalesMovements");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "SalesMovements");

            migrationBuilder.AddColumn<int>(
                name: "salesMovementId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "salesMovementId",
                table: "Personals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "salesMovementId",
                table: "Currrents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_salesMovementId",
                table: "Products",
                column: "salesMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Personals_salesMovementId",
                table: "Personals",
                column: "salesMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Currrents_salesMovementId",
                table: "Currrents",
                column: "salesMovementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Currrents_SalesMovements_salesMovementId",
                table: "Currrents",
                column: "salesMovementId",
                principalTable: "SalesMovements",
                principalColumn: "salesMovementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personals_SalesMovements_salesMovementId",
                table: "Personals",
                column: "salesMovementId",
                principalTable: "SalesMovements",
                principalColumn: "salesMovementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SalesMovements_salesMovementId",
                table: "Products",
                column: "salesMovementId",
                principalTable: "SalesMovements",
                principalColumn: "salesMovementId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
