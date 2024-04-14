

namespace BookAway.Application.Dtos.Reserva
{
    public class AddReservaDto
    {
        public int IdHotel { get; set; }
        public int IdUsuario { get; set; }
        public int IdHabitacion { get; set; }
        public int IdEstadoReserva { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Detalles { get; set; } = string.Empty;
    }
}
