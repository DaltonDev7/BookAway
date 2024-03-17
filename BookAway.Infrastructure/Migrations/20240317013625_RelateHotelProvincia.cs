using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAway.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RelateHotelProvincia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hoteles_Ciudades_IdCiudad",
                table: "Hoteles");

            migrationBuilder.DropIndex(
                name: "IX_Hoteles_IdCiudad",
                table: "Hoteles");

            migrationBuilder.DropColumn(
                name: "IdCiudad",
                table: "Hoteles");

            migrationBuilder.AddColumn<int>(
                name: "CiudadId",
                table: "Hoteles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProvincia",
                table: "Hoteles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hoteles_CiudadId",
                table: "Hoteles",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoteles_IdProvincia",
                table: "Hoteles",
                column: "IdProvincia");

            migrationBuilder.AddForeignKey(
                name: "FK_Hoteles_Ciudades_CiudadId",
                table: "Hoteles",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hoteles_Provincias_IdProvincia",
                table: "Hoteles",
                column: "IdProvincia",
                principalTable: "Provincias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hoteles_Ciudades_CiudadId",
                table: "Hoteles");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoteles_Provincias_IdProvincia",
                table: "Hoteles");

            migrationBuilder.DropIndex(
                name: "IX_Hoteles_CiudadId",
                table: "Hoteles");

            migrationBuilder.DropIndex(
                name: "IX_Hoteles_IdProvincia",
                table: "Hoteles");

            migrationBuilder.DropColumn(
                name: "CiudadId",
                table: "Hoteles");

            migrationBuilder.DropColumn(
                name: "IdProvincia",
                table: "Hoteles");

            migrationBuilder.AddColumn<int>(
                name: "IdCiudad",
                table: "Hoteles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hoteles_IdCiudad",
                table: "Hoteles",
                column: "IdCiudad");

            migrationBuilder.AddForeignKey(
                name: "FK_Hoteles_Ciudades_IdCiudad",
                table: "Hoteles",
                column: "IdCiudad",
                principalTable: "Ciudades",
                principalColumn: "Id");
        }
    }
}
