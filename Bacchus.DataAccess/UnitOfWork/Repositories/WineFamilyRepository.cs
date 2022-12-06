using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class WineFamilyRepository : IRepository<WineFamilyEntity>
{
    private readonly BacchusDbContext _dbContext;

    public WineFamilyRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(WineFamilyEntity wineFamilyEntity)
    {
        throw new NotImplementedException();
    }

    public List<WineFamilyEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public WineFamilyEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(WineFamilyEntity wineFamilyEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(WineFamilyEntity wineFamilyEntity)
    {
        throw new NotImplementedException();
    }
}
