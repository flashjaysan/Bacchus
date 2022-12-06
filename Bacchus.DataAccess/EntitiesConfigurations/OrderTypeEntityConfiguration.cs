﻿using Bacchus.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bacchus.DataAccess.EntitiesConfigurations;

public class OrderTypeEntityConfiguration : IEntityTypeConfiguration<OrderTypeEntity>
{
    public void Configure(EntityTypeBuilder<OrderTypeEntity> builder)
    {
        builder.HasKey(orderTypeEntity => orderTypeEntity.Id);
        builder.ToTable("OrderTypes");
        builder.Property(orderTypeEntity => orderTypeEntity.Id).ValueGeneratedOnAdd();
    }
}
