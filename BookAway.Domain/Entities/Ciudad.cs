

using BookAway.Domain.Entities.Common;

namespace BookAway.Domain.Entities
{
    public class Ciudad : BaseEntity
    {
        public string Descripcion { get; set; }

        public int IdProvincia { get; set; }


        public Provincia Provincia { get; set; }
        public ICollection<Hotel> Hoteles { get; set; }
    }
}
