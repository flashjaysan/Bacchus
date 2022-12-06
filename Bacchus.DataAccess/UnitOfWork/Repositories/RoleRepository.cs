using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class RoleRepository : IRepository<RoleEntity>
{
    private readonly BacchusDbContext _dbContext;

    public RoleRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(RoleEntity roleEntity)
    {
        _dbContext.Roles.Add(roleEntity);
    }

    public List<RoleEntity> GetAll()
    {
        return _dbContext.Roles.ToList();
    }

    public RoleEntity GetOne(int id)
    {
        return _dbContext.Roles.FirstOrDefault(role => role.Id == id);
    }

    public void Remove(RoleEntity roleEntity)
    {
        _dbContext.Roles.Remove(roleEntity);
    }

    public void Update(RoleEntity roleEntity)
    {
        _dbContext.Roles.Update(roleEntity);
    }
}
