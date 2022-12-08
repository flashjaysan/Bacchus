using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class OrderLineEntityConfiguration : IEntityTypeConfiguration<OrderWineEntity>
{
    public void Configure(EntityTypeBuilder<OrderWineEntity> builder)
    {
        builder.HasKey(orderLineEntity => orderLineEntity.Id);
        builder.ToTable("OrderLines");
        builder.Property(orderLineEntity => orderLineEntity.Id).ValueGeneratedOnAdd();
    }
}
