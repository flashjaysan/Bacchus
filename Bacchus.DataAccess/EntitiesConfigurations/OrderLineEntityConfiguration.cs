using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class OrderLineEntityConfiguration : IEntityTypeConfiguration<OrderLineEntity>
{
    public void Configure(EntityTypeBuilder<OrderLineEntity> builder)
    {
        throw new NotImplementedException();
    }
}
