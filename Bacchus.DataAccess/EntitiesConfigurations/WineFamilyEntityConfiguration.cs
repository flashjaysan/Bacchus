using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class WineFamilyEntityConfiguration : IEntityTypeConfiguration<WineFamilyEntity>
{
    public void Configure(EntityTypeBuilder<WineFamilyEntity> builder)
    {
        throw new NotImplementedException();
    }
}
