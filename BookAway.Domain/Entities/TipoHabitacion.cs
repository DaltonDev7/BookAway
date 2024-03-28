
using BookAway.Domain.Entities.Common;

namespace BookAway.Domain.Entities
{
    public class TipoHabitacion : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Habitacion> Habitaciones { get; set; }

    }
}
