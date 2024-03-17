using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAway.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RelateHotelPaisCiudad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Sexo",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Provincias",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Paises",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdPais",
                table: "Hoteles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IdCiudad",
                table: "Hoteles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Hoteles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Ciudades",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hoteles_IdCiudad",
                table: "Hoteles",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Hoteles_IdPais",
                table: "Hoteles",
                column: "IdPais");

            migrationBuilder.AddForeignKey(
                name: "FK_Hoteles_Ciudades_IdCiudad",
                table: "Hoteles",
                column: "IdCiudad",
                principalTable: "Ciudades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hoteles_Paises_IdPais",
                table: "Hoteles",
                column: "IdPais",
                principalTable: "Paises",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hoteles_Ciudades_IdCiudad",
                table: "Hoteles");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoteles_Paises_IdPais",
                table: "Hoteles");

            migrationBuilder.DropIndex(
                name: "IX_Hoteles_IdCiudad",
                table: "Hoteles");

            migrationBuilder.DropIndex(
                name: "IX_Hoteles_IdPais",
                table: "Hoteles");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Sexo");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Hoteles");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Ciudades");

            migrationBuilder.AlterColumn<string>(
                name: "IdPais",
                table: "Hoteles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IdCiudad",
                table: "Hoteles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
