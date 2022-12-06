using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class OrderRepository : IRepository<OrderEntity>
{
    private readonly BacchusDbContext _dbContext;

    public OrderRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(OrderEntity orderEntity)
    {
        throw new NotImplementedException();
    }

    public List<OrderEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public OrderEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(OrderEntity orderEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(OrderEntity orderEntity)
    {
        throw new NotImplementedException();
    }
}
