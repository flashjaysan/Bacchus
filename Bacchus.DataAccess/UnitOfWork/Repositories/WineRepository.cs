using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class WineRepository : IRepository<WineEntity>
{
    private readonly BacchusDbContext _dbContext;

    public WineRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(WineEntity wineEntity)
    {
        throw new NotImplementedException();
    }

    public List<WineEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public WineEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(WineEntity wineEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(WineEntity wineEntity)
    {
        throw new NotImplementedException();
    }
}
