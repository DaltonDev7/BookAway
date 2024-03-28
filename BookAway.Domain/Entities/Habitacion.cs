
using BookAway.Domain.Entities.Common;

namespace BookAway.Domain.Entities
{
    public class Habitacion : BaseEntity
    {
        public string Numero { get; set; }
        public bool Ocupado { get; set; } = false;
        public int IdTipoHabitacion { get; set; }

        public int IdHotel { get; set; }

        public double PrecioNoche { get; set; }

        public int Capacidad { get; set; }

        public TipoHabitacion TipoHabitacion { get; set; }
        public Hotel Hotel { get; set; }

    }
}
