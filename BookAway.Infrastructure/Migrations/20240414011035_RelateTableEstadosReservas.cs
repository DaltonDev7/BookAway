using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAway.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RelateTableEstadosReservas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Habitaciones_HabitacionId",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Hoteles_HotelId",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Usuarios_UsuarioId",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_HabitacionId",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_HotelId",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_UsuarioId",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "HabitacionId",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Reserva");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdEstadoReserva",
                table: "Reserva",
                column: "IdEstadoReserva");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdHabitacion",
                table: "Reserva",
                column: "IdHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdHotel",
                table: "Reserva",
                column: "IdHotel");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdUsuario",
                table: "Reserva",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_EstadosReservas_IdEstadoReserva",
                table: "Reserva",
                column: "IdEstadoReserva",
                principalTable: "EstadosReservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Habitaciones_IdHabitacion",
                table: "Reserva",
                column: "IdHabitacion",
                principalTable: "Habitaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Hoteles_IdHotel",
                table: "Reserva",
                column: "IdHotel",
                principalTable: "Hoteles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Usuarios_IdUsuario",
                table: "Reserva",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_EstadosReservas_IdEstadoReserva",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Habitaciones_IdHabitacion",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Hoteles_IdHotel",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Usuarios_IdUsuario",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IdEstadoReserva",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IdHabitacion",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IdHotel",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IdUsuario",
                table: "Reserva");

            migrationBuilder.AddColumn<int>(
                name: "HabitacionId",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_HabitacionId",
                table: "Reserva",
                column: "HabitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_HotelId",
                table: "Reserva",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuarioId",
                table: "Reserva",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Habitaciones_HabitacionId",
                table: "Reserva",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Hoteles_HotelId",
                table: "Reserva",
                column: "HotelId",
                principalTable: "Hoteles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Usuarios_UsuarioId",
                table: "Reserva",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
