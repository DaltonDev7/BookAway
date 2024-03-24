

using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAway.Infrastructure.EntityConfigurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hoteles");
            builder.HasKey(p => p.Id);
            builder.HasIndex(x => x.RNC).IsUnique();
            builder.HasIndex(x => x.Email).IsUnique();

            builder.HasOne(h => h.Pais)
                    .WithMany(p => p.Hoteles)
                    .HasForeignKey(h => h.IdPais)
                    .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(h => h.Provincia)
                  .WithMany(p => p.Hoteles)
                  .HasForeignKey(h => h.IdProvincia)
                  .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(h =>h.Rol)
                   .WithMany(r => r.Hoteles)
                   .HasForeignKey(h => h.IdRol)
                   .OnDelete(DeleteBehavior.ClientCascade);

        }
    }
}
