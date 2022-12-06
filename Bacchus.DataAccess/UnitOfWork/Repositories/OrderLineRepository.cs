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
        return _dbContext.OrderLines.ToList();
    }

    public OrderLineEntity GetOne(int id)
    {
        return _dbContext.OrderLines.FirstOrDefault(orderLine => orderLine.Id == id);
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
