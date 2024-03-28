
using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAway.Infrastructure.EntityConfigurations
{
    public class TipoHabitacionConfiguration : IEntityTypeConfiguration<TipoHabitacion>
    {
        public void Configure(EntityTypeBuilder<TipoHabitacion> builder)
        {
            builder.ToTable("TipoHabitacion");
            builder.HasKey(x =>x.Id);
        }
    }
}
