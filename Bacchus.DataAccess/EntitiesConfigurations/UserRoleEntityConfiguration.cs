using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class UserRoleEntityConfiguration : IEntityTypeConfiguration<UserRoleEntity>
{
    public void Configure(EntityTypeBuilder<UserRoleEntity> builder)
    {
        builder.HasKey(userRoleEntity => userRoleEntity.Id);
        builder.ToTable("UsersRoles");
        builder.Property(userRoleEntity => userRoleEntity.Id).ValueGeneratedOnAdd();
    }
}
