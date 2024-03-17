

using BookAway.Domain.Entities.Common;

namespace BookAway.Domain.Entities
{
    public class Pais : BaseEntity
    {
        public string Descripcion { get; set; }

        public ICollection<Provincia> Provincias { get; set; }

        public ICollection<Hotel> Hoteles { get; set; }
    }
}
