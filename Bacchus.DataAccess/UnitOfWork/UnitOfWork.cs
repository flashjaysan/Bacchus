using Bacchus.DataAccess.DbContext;

namespace Bacchus.DataAccess.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly BacchusDbContext _dbContext;

    public UnitOfWork(BacchusDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveIntoDbContextAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
