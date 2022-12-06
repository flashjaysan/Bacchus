using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class GrapeVarietyEntityConfiguration : IEntityTypeConfiguration<GrapeVarietyEntity>
{
    public void Configure(EntityTypeBuilder<GrapeVarietyEntity> builder)
    {
        builder.HasKey(grapeVarietyEntity => grapeVarietyEntity.Id);
        builder.ToTable("GrapeVarieties");
        builder.Property(grapeVarietyEntity => grapeVarietyEntity.Id).ValueGeneratedOnAdd();
    }
}
