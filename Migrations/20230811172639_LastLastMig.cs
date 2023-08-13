using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockAPI.Migrations
{
    /// <inheritdoc />
    public partial class LastLastMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Productnum_produit",
                table: "Sorties",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Productnum_produit",
                table: "Entrees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    num_produit = table.Column<string>(type: "TEXT", nullable: false),
                    design = table.Column<string>(type: "TEXT", nullable: false),
                    num_facture = table.Column<string>(type: "TEXT", nullable: false),
                    dateSortie = table.Column<DateTime>(type: "TEXT", nullable: false),
                    nom_client = table.Column<string>(type: "TEXT", nullable: false),
                    quantite_sortie = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    num_produit = table.Column<string>(type: "TEXT", nullable: false),
                    design = table.Column<string>(type: "TEXT", nullable: false),
                    num_bon_liv = table.Column<string>(type: "TEXT", nullable: false),
                    dateEntree = table.Column<DateTime>(type: "TEXT", nullable: false),
                    nom_fournisseur = table.Column<string>(type: "TEXT", nullable: false),
                    quantite_entree = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sorties_Productnum_produit",
                table: "Sorties",
                column: "Productnum_produit");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Productnum_produit",
                table: "Entrees",
                column: "Productnum_produit");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrees_Products_Productnum_produit",
                table: "Entrees",
                column: "Productnum_produit",
                principalTable: "Products",
                principalColumn: "num_produit");

            migrationBuilder.AddForeignKey(
                name: "FK_Sorties_Products_Productnum_produit",
                table: "Sorties",
                column: "Productnum_produit",
                principalTable: "Products",
                principalColumn: "num_produit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrees_Products_Productnum_produit",
                table: "Entrees");

            migrationBuilder.DropForeignKey(
                name: "FK_Sorties_Products_Productnum_produit",
                table: "Sorties");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Sorties_Productnum_produit",
                table: "Sorties");

            migrationBuilder.DropIndex(
                name: "IX_Entrees_Productnum_produit",
                table: "Entrees");

            migrationBuilder.DropColumn(
                name: "Productnum_produit",
                table: "Sorties");

            migrationBuilder.DropColumn(
                name: "Productnum_produit",
                table: "Entrees");
        }
    }
}
