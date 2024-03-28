

using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAway.Infrastructure.EntityConfigurations
{
    public class HotelServicioConfiguration : IEntityTypeConfiguration<HotelServicio>
    {
        public void Configure(EntityTypeBuilder<HotelServicio> builder)
        {
            builder.ToTable("ServiciosHotel");
            builder.HasKey(x => x.Id);
        }
    }
}
