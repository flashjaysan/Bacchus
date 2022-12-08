using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class OrderLineRepository : IRepository<OrderWineEntity>
{
    private readonly BacchusDbContext _dbContext;

    public OrderLineRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(OrderWineEntity orderLineEntity)
    {
        _dbContext.OrderLines.Add(orderLineEntity);
    }

    public List<OrderWineEntity> GetAll()
    {
        return _dbContext.OrderLines.ToList();
    }

    public OrderWineEntity GetOne(int id)
    {
        return _dbContext.OrderLines.FirstOrDefault(orderLine => orderLine.Id == id);
    }

    public void Remove(OrderWineEntity orderLineEntity)
    {
        _dbContext.OrderLines.Remove(orderLineEntity);
    }

    public void Update(OrderWineEntity orderLineEntity)
    {
        _dbContext.OrderLines.Update(orderLineEntity);
    }
}
