using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAway.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class relateHotelHabitacionTipoHabitaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdHabitacion",
                table: "Habitaciones",
                newName: "IdTipoHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_IdHotel",
                table: "Habitaciones",
                column: "IdHotel");

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_IdTipoHabitacion",
                table: "Habitaciones",
                column: "IdTipoHabitacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitaciones_Hoteles_IdHotel",
                table: "Habitaciones",
                column: "IdHotel",
                principalTable: "Hoteles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitaciones_TipoHabitacion_IdTipoHabitacion",
                table: "Habitaciones",
                column: "IdTipoHabitacion",
                principalTable: "TipoHabitacion",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitaciones_Hoteles_IdHotel",
                table: "Habitaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Habitaciones_TipoHabitacion_IdTipoHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropIndex(
                name: "IX_Habitaciones_IdHotel",
                table: "Habitaciones");

            migrationBuilder.DropIndex(
                name: "IX_Habitaciones_IdTipoHabitacion",
                table: "Habitaciones");

            migrationBuilder.RenameColumn(
                name: "IdTipoHabitacion",
                table: "Habitaciones",
                newName: "IdHabitacion");
        }
    }
}
