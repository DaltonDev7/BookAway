

using Microsoft.AspNetCore.Identity;

namespace BookAway.Domain.Entities
{
    public class RolUsuario : IdentityUserRole<int>
    {
        public Usuario Usuario { get; set; }
        public Rol Rol { get; set; }
    }
}
