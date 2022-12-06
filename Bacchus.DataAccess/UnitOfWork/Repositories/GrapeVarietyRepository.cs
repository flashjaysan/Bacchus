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
        return _dbContext.GrapeVarieties.ToList();
    }

    public GrapeVarietyEntity GetOne(int id)
    {
        return _dbContext.GrapeVarieties.FirstOrDefault(grapeVariety => grapeVariety.Id == id);
    }

    public void Remove(GrapeVarietyEntity grapeVarietyEntity)
    {
        _dbContext.GrapeVarieties.Remove(grapeVarietyEntity);
    }

    public void Update(GrapeVarietyEntity grapeVarietyEntity)
    {
        _dbContext.GrapeVarieties.Update(grapeVarietyEntity);
    }
}
