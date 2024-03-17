
using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAway.Infrastructure.EntityConfigurations
{
    public class ProvinciaConfiguration : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder)
        {
            builder.ToTable("Provincias");
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Pais)
                   .WithMany(p => p.Provincias)
                   .HasForeignKey(c => c.IdPais)
                   .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
