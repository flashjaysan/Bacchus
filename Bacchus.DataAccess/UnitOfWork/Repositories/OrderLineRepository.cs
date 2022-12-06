using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class OrderLineRepository : IRepository<OrderLineEntity>
{
    private readonly BacchusDbContext _dbContext;

    public OrderLineRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(OrderLineEntity orderLineEntity)
    {
        _dbContext.OrderLines.Add(orderLineEntity);
    }

    public List<OrderLineEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public OrderLineEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(OrderLineEntity orderLineEntity)
    {
        _dbContext.OrderLines.Remove(orderLineEntity);
    }

    public void Update(OrderLineEntity orderLineEntity)
    {
        _dbContext.OrderLines.Update(orderLineEntity);
    }
}
