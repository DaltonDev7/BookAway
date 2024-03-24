using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAway.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addRolHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdRol",
                table: "Hoteles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hoteles_IdRol",
                table: "Hoteles",
                column: "IdRol");

            migrationBuilder.AddForeignKey(
                name: "FK_Hoteles_AspNetRoles_IdRol",
                table: "Hoteles",
                column: "IdRol",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hoteles_AspNetRoles_IdRol",
                table: "Hoteles");

            migrationBuilder.DropIndex(
                name: "IX_Hoteles_IdRol",
                table: "Hoteles");

            migrationBuilder.DropColumn(
                name: "IdRol",
                table: "Hoteles");
        }
    }
}
