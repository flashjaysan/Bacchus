using Bacchus.Common.Entities;
using Bacchus.DataAccess.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Bacchus.DataAccess.DbContext;

public class BacchusDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<GrapeVarietyEntity> GrapeVarieties { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<OrderWineEntity> OrderWines { get; set; }
    public DbSet<OrderStatusEntity> OrderStatuses { get; set; }
    public DbSet<OrderTypeEntity> OrderTypes { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<SupplierEntity> Suppliers { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<UserRoleEntity> UsersRoles { get; set; }
    public DbSet<WineEntity> Wines { get; set; }
    public DbSet<WineFamilyEntity> WineFamilies { get; set; }

    public BacchusDbContext(DbContextOptions<BacchusDbContext> options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
        modelBuilder.ApplyConfiguration(new GrapeVarietyEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderStatusEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderTypeEntityConfiguration());
        modelBuilder.ApplyConfiguration(new RoleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new SupplierEntityConfiguration());
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        modelBuilder.ApplyConfiguration(new WineEntityConfiguration());
        modelBuilder.ApplyConfiguration(new WineFamilyEntityConfiguration());
    }
}
