using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class OrderStatusEntityConfiguration : IEntityTypeConfiguration<OrderStatusEntity>
{
    public void Configure(EntityTypeBuilder<OrderStatusEntity> builder)
    {
        builder.HasKey(orderStatusEntity => orderStatusEntity.Id);
        builder.ToTable("OrderStatuses");
        builder.Property(orderStatusEntity => orderStatusEntity.Id).ValueGeneratedNever();
    }
}
