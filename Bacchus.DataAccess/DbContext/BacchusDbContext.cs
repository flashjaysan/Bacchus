using Bacchus.Common.Entities;
using Bacchus.DataAccess.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Bacchus.DataAccess.DbContext;

public class BacchusDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<UserRoleEntity> UserRoles { get; set; }

    public BacchusDbContext(DbContextOptions<BacchusDbContext> options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
        modelBuilder.ApplyConfiguration(new GrapeVarietyEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderLineEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderStatusEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderTypeEntityConfiguration());
        modelBuilder.ApplyConfiguration(new RoleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new SupplierEntityConfiguration());
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        modelBuilder.ApplyConfiguration(new UserRoleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new WineEntityConfiguration());
        modelBuilder.ApplyConfiguration(new WineFamilyEntityConfiguration());
    }
}
