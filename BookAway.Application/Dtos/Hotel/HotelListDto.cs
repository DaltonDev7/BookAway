
namespace BookAway.Application.Dtos.Hotel
{
    public class HotelListDto
    {
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string RNC { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public double CalificacionPromedio { get; set; }
        public int IdPais { get; set; }
        public int? IdProvincia { get; set; }
    }
}
