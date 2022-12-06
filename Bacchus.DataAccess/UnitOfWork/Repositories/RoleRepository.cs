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
        throw new NotImplementedException();
    }

    public RoleEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(RoleEntity roleEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(RoleEntity roleEntity)
    {
        throw new NotImplementedException();
    }
}
