
using BookAway.Domain.Entities.Common;

namespace BookAway.Domain.Entities
{
    public class Provincia : BaseEntity
    {
        public string Descripcion { get; set; }
        public int IdPais { get; set; }



        public Pais Pais { get; set; }
        public ICollection<Ciudad> Ciudades { get; set; }
        public ICollection<Hotel>? Hoteles { get; set; }
    }
}
