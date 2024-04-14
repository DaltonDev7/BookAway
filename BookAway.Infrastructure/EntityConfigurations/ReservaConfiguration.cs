

using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAway.Infrastructure.EntityConfigurations
{
    public class ReservaConfiguration : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.ToTable("Reserva");
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.EstadoReserva)
                   .WithMany(r => r.Reservas)
                   .HasForeignKey(e => e.IdEstadoReserva);

            builder.HasOne(e => e.Hotel)
                  .WithMany(r => r.Reservas)
                  .HasForeignKey(e => e.IdHotel);

            builder.HasOne(e => e.Habitacion)
                  .WithMany(r => r.Reservas)
                  .HasForeignKey(e => e.IdHabitacion);

            builder.HasOne(e => e.Usuario)
                  .WithMany(r => r.Reservas)
                  .HasForeignKey(e => e.IdUsuario);
        }
    }
}
