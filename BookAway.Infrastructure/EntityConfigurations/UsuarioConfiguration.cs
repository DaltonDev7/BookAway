using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace BookAway.Infrastructure.EntityConfigurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasIndex(x => x.Identificacion).IsUnique();
            builder.Property(x => x.Nombres).HasMaxLength(50);
            builder.Property(m => m.Apellidos).HasMaxLength(50);

            builder.HasOne(u => u.Sexo)
                 .WithMany(s => s.Usuarios)
                 .HasForeignKey(u => u.IdSexo)
                 .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
