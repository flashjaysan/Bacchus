using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class SupplierEntityConfiguration : IEntityTypeConfiguration<SupplierEntity>
{
    public void Configure(EntityTypeBuilder<SupplierEntity> builder)
    {
        builder.HasKey(supplierEntity => supplierEntity.Id);
        builder.ToTable("Suppliers");
        builder.Property(supplierEntity => supplierEntity.Id).ValueGeneratedOnAdd();
    }
}
