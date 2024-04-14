

using BookAway.Domain.Entities.Common;

namespace BookAway.Domain.Entities
{
    public class EstadoReserva : BaseEntity
    {
        public string Descripcion { get; set; } = string.Empty;

        public ICollection<Reserva> Reservas { get; set; } = null!;
    }
}
