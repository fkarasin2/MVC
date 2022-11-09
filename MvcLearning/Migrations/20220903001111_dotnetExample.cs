using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MvcLearning.Migrations
{
    /// <inheritdoc />
    public partial class dotnetExample : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userName = table.Column<string>(type: "Varchar", maxLength: 15, nullable: false),
                    password = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    permission = table.Column<string>(type: "Char", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    categoryName = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    departmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    departmentName = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.departmentId);
                });

            migrationBuilder.CreateTable(
                name: "Expensies",
                columns: table => new
                {
                    expenseID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    expenseDescription = table.Column<string>(type: "Varchar", maxLength: 100, nullable: false),
                    expenseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    expensePrice = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expensies", x => x.expenseID);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    invoiceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    invoiceSerialNo = table.Column<string>(type: "Char", maxLength: 10, nullable: false),
                    invoiceSortNo = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    invoiceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    taxBranch = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    invoiceHour = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    invoiceSubmitter = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    invoiceDelivery = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.invoiceId);
                });

            migrationBuilder.CreateTable(
                name: "SalesMovements",
                columns: table => new
                {
                    salesMovementId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    salesMovementDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    count = table.Column<int>(type: "integer", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    totalPrice = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesMovements", x => x.salesMovementId);
                });

            migrationBuilder.CreateTable(
                name: "FaturaKalems",
                columns: table => new
                {
                    faturaKalemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Aciklama = table.Column<string>(type: "Varchar", maxLength: 100, nullable: false),
                    Miktar = table.Column<int>(type: "integer", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "numeric", nullable: false),
                    Tutar = table.Column<decimal>(type: "numeric", nullable: false),
                    invoiceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaKalems", x => x.faturaKalemId);
                    table.ForeignKey(
                        name: "FK_FaturaKalems_Invoices_invoiceId",
                        column: x => x.invoiceId,
                        principalTable: "Invoices",
                        principalColumn: "invoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Currrents",
                columns: table => new
                {
                    currentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    currentName = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    currentSurname = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    currentCity = table.Column<string>(type: "Varchar", maxLength: 15, nullable: false),
                    currentMail = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    salesMovementId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currrents", x => x.currentId);
                    table.ForeignKey(
                        name: "FK_Currrents_SalesMovements_salesMovementId",
                        column: x => x.salesMovementId,
                        principalTable: "SalesMovements",
                        principalColumn: "salesMovementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    personalId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personalName = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    personalSurname = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    personalImg = table.Column<string>(type: "Varchar", maxLength: 250, nullable: false),
                    salesMovementId = table.Column<int>(type: "integer", nullable: false),
                    departmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.personalId);
                    table.ForeignKey(
                        name: "FK_Personals_Departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "Departments",
                        principalColumn: "departmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personals_SalesMovements_salesMovementId",
                        column: x => x.salesMovementId,
                        principalTable: "SalesMovements",
                        principalColumn: "salesMovementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    productName = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    productBrand = table.Column<string>(type: "Varchar", maxLength: 40, nullable: false),
                    stockCounts = table.Column<short>(type: "smallint", nullable: false),
                    buyPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    sellPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    state = table.Column<bool>(type: "boolean", nullable: false),
                    productImg = table.Column<string>(type: "Varchar", maxLength: 250, nullable: false),
                    categoryId = table.Column<int>(type: "integer", nullable: false),
                    salesMovementId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SalesMovements_salesMovementId",
                        column: x => x.salesMovementId,
                        principalTable: "SalesMovements",
                        principalColumn: "salesMovementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Currrents_salesMovementId",
                table: "Currrents",
                column: "salesMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaKalems_invoiceId",
                table: "FaturaKalems",
                column: "invoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Personals_departmentId",
                table: "Personals",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Personals_salesMovementId",
                table: "Personals",
                column: "salesMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_salesMovementId",
                table: "Products",
                column: "salesMovementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Currrents");

            migrationBuilder.DropTable(
                name: "Expensies");

            migrationBuilder.DropTable(
                name: "FaturaKalems");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "SalesMovements");
        }
    }
}
