
using BookAway.Domain.Entities;
using BookAway.Infrastructure.EntityConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookAway.Infrastructure.Context
{
    public class BookAwayContext : IdentityDbContext<Usuario, Rol, int, IdentityUserClaim<int>, RolUsuario, IdentityUserLogin<int>,
    IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public BookAwayContext(DbContextOptions<BookAwayContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RolUsuarioConfiguration());
        }


        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolUsuario> RolUsuario { get; set; }


    }
}
