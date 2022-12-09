﻿using Bacchus.Common.Entities;
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

    public void Add(OrderWineEntity orderWineEntity)
    {
        _dbContext.OrderWines.Add(orderWineEntity);
    }

    public List<OrderWineEntity> GetAll()
    {
        return _dbContext.OrderWines.ToList();
    }

    public OrderWineEntity GetOne(int id)
    {
        return _dbContext.OrderWines.FirstOrDefault(orderWine => orderWine.Id == id);
    }

    public void Remove(OrderWineEntity orderWineEntity)
    {
        _dbContext.OrderWines.Remove(orderWineEntity);
    }

    public void Update(OrderWineEntity orderLineEntity)
    {
        _dbContext.OrderWines.Update(orderLineEntity);
    }
}
