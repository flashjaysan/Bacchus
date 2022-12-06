using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

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
        _dbContext.Orders.Add(orderEntity);
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
        _dbContext.Orders.Remove(orderEntity);
    }

    public void Update(OrderEntity orderEntity)
    {
        _dbContext.Orders.Update(orderEntity);
    }
}
