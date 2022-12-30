using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class WineEntityConfiguration : IEntityTypeConfiguration<WineEntity>
{
    public void Configure(EntityTypeBuilder<WineEntity> builder)
    {
        builder.HasKey(wineEntity => wineEntity.Id);
        builder.ToTable("Wines");
        builder.Property(wineEntity => wineEntity.Id).ValueGeneratedOnAdd();

        builder
            .HasMany<OrderWineEntity>()
            .WithOne(orderWineEntity => orderWineEntity.Wine)
            .HasForeignKey(orderWineEntity => orderWineEntity.WineId)
            .IsRequired();

        builder
        .HasMany<SupplierWineEntity>()
        .WithOne(supplierWineEntity => supplierWineEntity.Wine)
        .HasForeignKey(supplierWineEntity => supplierWineEntity.WineId)
        .IsRequired();
    }
}
