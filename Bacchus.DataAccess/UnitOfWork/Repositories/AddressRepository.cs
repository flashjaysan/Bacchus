using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

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
        _dbContext.Addresses.Add(addressEntity);
    }

    public List<AddressEntity> GetAll()
    {
        return _dbContext.Addresses.ToList();
    }

    public AddressEntity GetOne(int id)
    {
        return _dbContext.Addresses.FirstOrDefault(address => address.Id == id);
    }

    public void Remove(AddressEntity addressEntity)
    {
        _dbContext.Addresses.Remove(addressEntity);
    }

    public void Update(AddressEntity addressEntity)
    {
        _dbContext.Addresses.Update(addressEntity);
    }
}
