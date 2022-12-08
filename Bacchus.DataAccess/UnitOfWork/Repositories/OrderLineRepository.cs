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
        _dbContext.OrderWines.Add(orderLineEntity);
    }

    public List<OrderWineEntity> GetAll()
    {
        return _dbContext.OrderWines.ToList();
    }

    public OrderWineEntity GetOne(int id)
    {
        return _dbContext.OrderWines.FirstOrDefault(orderLine => orderLine.Id == id);
    }

    public void Remove(OrderWineEntity orderLineEntity)
    {
        _dbContext.OrderWines.Remove(orderLineEntity);
    }

    public void Update(OrderWineEntity orderLineEntity)
    {
        _dbContext.OrderWines.Update(orderLineEntity);
    }
}
