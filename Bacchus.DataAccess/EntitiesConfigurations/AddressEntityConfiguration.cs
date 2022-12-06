using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class AddressEntityConfiguration : IEntityTypeConfiguration<AddressEntity>
{
    public void Configure(EntityTypeBuilder<AddressEntity> builder)
    {
        builder.HasKey(addressEntity => addressEntity.Id);
        builder.ToTable("Addresses");
        builder.Property(addressEntity => addressEntity.Id).ValueGeneratedOnAdd();
    }
}
