
using BookAway.Domain.Entities.Common;

namespace BookAway.Domain.Entities
{
    public class Reserva : BaseEntity
    {
        public int IdHotel { get; set; }
        public int IdUsuario { get; set; }
        public int IdHabitacion { get; set; }
        public int IdEstadoReserva { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Detalles { get; set; } = string.Empty;

        public Hotel Hotel { get; set; }
        public Usuario Usuario { get; set; }
        public Habitacion Habitacion { get; set; }
        public EstadoReserva EstadoReserva { get; set; }
    }
}
