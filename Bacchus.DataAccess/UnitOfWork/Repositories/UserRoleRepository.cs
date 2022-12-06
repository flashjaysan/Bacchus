using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class UserRoleRepository : IRepository<UserRoleEntity>
{
    private readonly BacchusDbContext _dbContext;

    public UserRoleRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(UserRoleEntity userRoleEntity)
    {
        throw new NotImplementedException();
    }

    public List<UserRoleEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public UserRoleEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(UserRoleEntity userRoleEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(UserRoleEntity userRoleEntity)
    {
        throw new NotImplementedException();
    }
}
