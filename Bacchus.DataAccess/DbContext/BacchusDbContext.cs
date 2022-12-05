using Bacchus.Common.Entities;
using EntitiesConfigurations;
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

        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        modelBuilder.ApplyConfiguration(new RoleEntityConfiguration());
    }
}
