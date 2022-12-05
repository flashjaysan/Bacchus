using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class WineEntityConfiguration : IEntityTypeConfiguration<WineEntity>
{
    public void Configure(EntityTypeBuilder<WineEntity> builder)
    {
        throw new NotImplementedException();
    }
}
