using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockAPI.Migrations
{
    /// <inheritdoc />
    public partial class LastMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sortienum_facture",
                table: "Destockages",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destockages_Sortienum_facture",
                table: "Destockages",
                column: "Sortienum_facture");

            migrationBuilder.AddForeignKey(
                name: "FK_Destockages_Sorties_Sortienum_facture",
                table: "Destockages",
                column: "Sortienum_facture",
                principalTable: "Sorties",
                principalColumn: "num_facture");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destockages_Sorties_Sortienum_facture",
                table: "Destockages");

            migrationBuilder.DropIndex(
                name: "IX_Destockages_Sortienum_facture",
                table: "Destockages");

            migrationBuilder.DropColumn(
                name: "Sortienum_facture",
                table: "Destockages");
        }
    }
}
