
using BookAway.Domain.Entities;

namespace BookAway.Application.Dtos.Auth
{
    public class UserResponseSignInDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int IdSexo { get; set; }

        public string Rol { get; set; }

    }
}
