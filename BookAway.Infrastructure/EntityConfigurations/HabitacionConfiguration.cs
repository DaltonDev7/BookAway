
using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAway.Infrastructure.EntityConfigurations
{
    public class HabitacionConfiguration : IEntityTypeConfiguration<Habitacion>
    {
        public void Configure(EntityTypeBuilder<Habitacion> builder)
        {
            builder.ToTable("Habitaciones");
            builder.HasKey(x => x.Id);

            builder.HasOne(h => h.TipoHabitacion)
                   .WithMany(t => t.Habitaciones)
                   .HasForeignKey(h => h.IdTipoHabitacion)
                   .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(h => h.Hotel)
                  .WithMany(t => t.Habitaciones)
                  .HasForeignKey(h => h.IdHotel)
                  .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
