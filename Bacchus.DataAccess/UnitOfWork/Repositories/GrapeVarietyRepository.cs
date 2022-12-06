using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class GrapeVarietyRepository : IRepository<GrapeVarietyEntity>
{
    private readonly BacchusDbContext _dbContext;

    public GrapeVarietyRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(GrapeVarietyEntity grapeVarietyEntity)
    {
        _dbContext.GrapeVarieties.Add(grapeVarietyEntity);
    }

    public List<GrapeVarietyEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public GrapeVarietyEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(GrapeVarietyEntity grapeVarietyEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(GrapeVarietyEntity grapeVarietyEntity)
    {
        throw new NotImplementedException();
    }
}
