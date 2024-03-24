

namespace BookAway.Application.Dtos
{
    public class AddUpdateHotelDto
    {
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string RNC { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string Contacto { get; set; }
        public double CalificacionPromedio { get; set; } = 0.0;
        public int IdPais { get; set; }
        public int? IdRol { get; set; } = 2;
        public int? IdProvincia { get; set; }
    }
}
