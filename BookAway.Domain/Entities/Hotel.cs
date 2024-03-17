

using BookAway.Domain.Entities.Common;

namespace BookAway.Domain.Entities
{
    public class Hotel : BaseEntity
    {
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string RNC { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string Telefono { get; set; }
        public double CalificacionPromedio { get; set; } = 0.0;
        public int IdPais { get; set; }
        public int? IdProvincia { get; set; }



        public Pais Pais { get; set; }
        public Provincia? Provincia { get; set; }
    }
}
