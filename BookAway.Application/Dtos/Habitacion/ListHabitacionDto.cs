

namespace BookAway.Application.Dtos.Habitacion
{
    public class ListHabitacionDto
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public bool Ocupado { get; set; } = false;
        public string TipoHabitacion { get; set; }

        public string Hotel { get; set; }

        public double PrecioNoche { get; set; }

        public int Capacidad { get; set; }
    }
}
