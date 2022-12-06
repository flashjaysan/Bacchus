using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class OrderTypeRepository : IRepository<OrderTypeEntity>
{
    private readonly BacchusDbContext _dbContext;

    public OrderTypeRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(OrderTypeEntity orderTypeEntity)
    {
        _dbContext.OrderTypes.Add(orderTypeEntity);
    }

    public List<OrderTypeEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public OrderTypeEntity GetOne(int id)
    {
        return _dbContext.OrderTypes.FirstOrDefault(orderType => orderType.Id == id);
    }

    public void Remove(OrderTypeEntity orderTypeEntity)
    {
        _dbContext.OrderTypes.Remove(orderTypeEntity);
    }

    public void Update(OrderTypeEntity orderTypeEntity)
    {
        _dbContext.OrderTypes.Update(orderTypeEntity);
    }
}
