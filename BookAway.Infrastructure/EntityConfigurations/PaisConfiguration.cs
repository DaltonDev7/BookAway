
using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAway.Infrastructure.EntityConfigurations
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {

        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Paises");
            builder.HasKey(p => p.Id);
        }
    }
}
