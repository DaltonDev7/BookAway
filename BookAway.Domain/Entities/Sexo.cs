
using BookAway.Domain.Entities.Common;

namespace BookAway.Domain.Entities
{
    public class Sexo : BaseEntity
    {
        public string Descripcion { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
