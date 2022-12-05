using Bacchus.DataAccess.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Bacchus.DataAccess.DbContextFactory;

public class BacchusDbContextFactory : IDesignTimeDbContextFactory<BacchusDbContext>
{
    readonly IConfigurationRoot _configuration = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json")
       .Build();

    public BacchusDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<BacchusDbContext> builder = new DbContextOptionsBuilder<BacchusDbContext>();
        builder.UseSqlServer(_configuration.GetConnectionString("BacchusDb"), builder => builder.MigrationsAssembly("Bacchus.DataAccess"));
        return new BacchusDbContext(builder.Options);
    }
}
