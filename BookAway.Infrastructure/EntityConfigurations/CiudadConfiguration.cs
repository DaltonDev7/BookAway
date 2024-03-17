
using BookAway.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookAway.Infrastructure.EntityConfigurations
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("Ciudades");
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Provincia)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(p => p.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientCascade);

        }
    }
}
