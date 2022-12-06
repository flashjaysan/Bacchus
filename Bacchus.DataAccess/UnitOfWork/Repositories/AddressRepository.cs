using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class AddressRepository : IRepository<AddressEntity>
{
    private readonly BacchusDbContext _dbContext;

    public AddressRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(AddressEntity addressEntity)
    {
        throw new NotImplementedException();
    }

    public List<AddressEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public AddressEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(AddressEntity addressEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(AddressEntity addressEntity)
    {
        throw new NotImplementedException();
    }
}
