using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class WineFamilyEntityConfiguration : IEntityTypeConfiguration<WineFamilyEntity>
{
    public void Configure(EntityTypeBuilder<WineFamilyEntity> builder)
    {
        builder.HasKey(wineFamilyEntity => wineFamilyEntity.Id);
        builder.ToTable("WineFamilies");
        builder.Property(wineFamilyEntity => wineFamilyEntity.Id).ValueGeneratedOnAdd();
    }
}
