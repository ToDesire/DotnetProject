using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockAPI.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Entreenum_bon_liv",
                table: "Stockages",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    NumBon = table.Column<string>(type: "TEXT", nullable: false),
                    DateActivite = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TypeActivite = table.Column<string>(type: "TEXT", nullable: false),
                    NomClientFournisseur = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MonthlyRankResults",
                columns: table => new
                {
                    num_produit = table.Column<string>(type: "TEXT", nullable: false),
                    design = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    image = table.Column<string>(type: "TEXT", nullable: false),
                    quantite = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalSorties = table.Column<int>(type: "INTEGER", nullable: false),
                    Month = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "StatisticsResults",
                columns: table => new
                {
                    Month = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    NbrEntree = table.Column<int>(type: "INTEGER", nullable: false),
                    NbrSortie = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "StockagesWithDesignation",
                columns: table => new
                {
                    num_bon_liv = table.Column<string>(type: "TEXT", nullable: false),
                    num_produit = table.Column<string>(type: "TEXT", nullable: false),
                    quantite_entree = table.Column<int>(type: "INTEGER", nullable: false),
                    design = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stockages_Entreenum_bon_liv",
                table: "Stockages",
                column: "Entreenum_bon_liv");

            migrationBuilder.AddForeignKey(
                name: "FK_Stockages_Entrees_Entreenum_bon_liv",
                table: "Stockages",
                column: "Entreenum_bon_liv",
                principalTable: "Entrees",
                principalColumn: "num_bon_liv");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stockages_Entrees_Entreenum_bon_liv",
                table: "Stockages");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "MonthlyRankResults");

            migrationBuilder.DropTable(
                name: "StatisticsResults");

            migrationBuilder.DropTable(
                name: "StockagesWithDesignation");

            migrationBuilder.DropIndex(
                name: "IX_Stockages_Entreenum_bon_liv",
                table: "Stockages");

            migrationBuilder.DropColumn(
                name: "Entreenum_bon_liv",
                table: "Stockages");
        }
    }
}
