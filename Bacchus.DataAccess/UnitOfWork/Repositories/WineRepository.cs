using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

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
        _dbContext.Wines.Add(wineEntity);
    }

    public List<WineEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public WineEntity GetOne(int id)
    {
        return _dbContext.Wines.FirstOrDefault(wine => wine.Id == id);
    }

    public void Remove(WineEntity wineEntity)
    {
        _dbContext.Wines.Remove(wineEntity);
    }

    public void Update(WineEntity wineEntity)
    {
        _dbContext.Wines.Update(wineEntity);
    }
}
