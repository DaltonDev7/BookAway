namespace BookAway.Application.Dtos.Auth
{
    public class SignUpDto
    {
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Apellidos { get; set; }
        public int IdSexo { get; set; }
        public string Contacto { get; set; }
        public string Identificacion { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
