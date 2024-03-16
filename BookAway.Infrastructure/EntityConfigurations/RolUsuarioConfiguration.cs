

using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookAway.Infrastructure.EntityConfigurations
{
    public class RolUsuarioConfiguration : IEntityTypeConfiguration<RolUsuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RolUsuario> builder)
        {
            builder.ToTable("RolesUsuario");
            builder.HasKey(c => new { c.UserId, c.RoleId });

            builder.HasOne(ur => ur.Rol)
               .WithMany(r => r.RolesUsuarios)
               .HasForeignKey(ur => ur.RoleId)
               .IsRequired();

            builder.HasOne(ur => ur.Usuario)
           .WithMany(r => r.RolesUsuarios)
           .HasForeignKey(ur => ur.UserId)
           .IsRequired();
        }
    }
}
