
namespace BookAway.Application.Dtos.Habitacion
{
    public class AddHabitacionDto
    {
        public string Numero { get; set; }
        public bool Ocupado { get; set; } = false;
        public int IdTipoHabitacion { get; set; }

        public int IdHotel { get; set; }

        public double PrecioNoche { get; set; }

        public int Capacidad { get; set; }
    }
}
