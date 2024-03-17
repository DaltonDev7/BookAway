using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAway.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RelateTableCiudadPaisProvincia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPais",
                table: "Provincias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProvincia",
                table: "Ciudades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_IdPais",
                table: "Provincias",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_IdProvincia",
                table: "Ciudades",
                column: "IdProvincia");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Provincias_IdProvincia",
                table: "Ciudades",
                column: "IdProvincia",
                principalTable: "Provincias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Paises_IdPais",
                table: "Provincias",
                column: "IdPais",
                principalTable: "Paises",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Provincias_IdProvincia",
                table: "Ciudades");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Paises_IdPais",
                table: "Provincias");

            migrationBuilder.DropIndex(
                name: "IX_Provincias_IdPais",
                table: "Provincias");

            migrationBuilder.DropIndex(
                name: "IX_Ciudades_IdProvincia",
                table: "Ciudades");

            migrationBuilder.DropColumn(
                name: "IdPais",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "IdProvincia",
                table: "Ciudades");
        }
    }
}
