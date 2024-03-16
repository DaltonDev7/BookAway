

using Microsoft.AspNetCore.Identity;

namespace BookAway.Domain.Entities
{
    public class Usuario : IdentityUser<int>
    {
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public int IdSexo { get; set; }
        public string Identificacion { get; set; } = null!;
        public bool Estado { get; set; }

        public ICollection<RolUsuario> RolesUsuarios { get; set; } = null!;
    }
}
