

using Microsoft.AspNetCore.Identity;

namespace BookAway.Domain.Entities
{
    public class Usuario : IdentityUser<int>
    {
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public int IdSexo { get; set; }
        public string Identificacion { get; set; } = null!;
        public string Contacto { get; set; }
        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; }

        public ICollection<RolUsuario> RolesUsuarios { get; set; } = null!;
        public Sexo Sexo { get; set; } = null!;

        public ICollection<Reserva> Reservas { get; set; } = null!;
    }
}
