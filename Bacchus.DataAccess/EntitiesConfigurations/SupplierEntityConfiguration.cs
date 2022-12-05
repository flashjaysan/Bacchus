using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class SupplierEntityConfiguration : IEntityTypeConfiguration<SupplierEntity>
{
    public void Configure(EntityTypeBuilder<SupplierEntity> builder)
    {
        throw new NotImplementedException();
    }
}
