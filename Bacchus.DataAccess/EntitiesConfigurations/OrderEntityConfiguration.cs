using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class OrderEntityConfiguration : IEntityTypeConfiguration<OrderEntity>
{
    public void Configure(EntityTypeBuilder<OrderEntity> builder)
    {
        builder.HasKey(orderEntity => orderEntity.Id);
        builder.ToTable("Orders");
        builder.Property(orderEntity => orderEntity.Id).ValueGeneratedOnAdd();
    }
}
