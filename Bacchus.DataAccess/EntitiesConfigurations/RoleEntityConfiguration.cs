﻿using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class RoleEntityConfiguration : IEntityTypeConfiguration<RoleEntity>
{
    public void Configure(EntityTypeBuilder<RoleEntity> builder)
    {
        builder.HasKey(roleEntity => roleEntity.Id);
        builder.ToTable("Roles");
        builder.Property(roleEntity => roleEntity.Id).ValueGeneratedOnAdd();
    }
}
