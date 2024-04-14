
using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAway.Infrastructure.EntityConfigurations
{
    public class EstadoReservaConfiguration : IEntityTypeConfiguration<EstadoReserva>
    {
        public void Configure(EntityTypeBuilder<EstadoReserva> builder)
        {
            builder.ToTable("EstadosReservas");
            builder.HasKey(x => x.Id);
        }
    }
}
