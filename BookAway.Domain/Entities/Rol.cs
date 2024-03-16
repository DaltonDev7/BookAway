

using Microsoft.AspNetCore.Identity;

namespace BookAway.Domain.Entities
{
    public class Rol : IdentityRole<int>
    {
        public ICollection<RolUsuario> RolesUsuarios { get; set; }
    }
}
