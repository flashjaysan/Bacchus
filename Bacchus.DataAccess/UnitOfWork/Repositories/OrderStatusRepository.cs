﻿using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class OrderStatusRepository : IRepository<OrderStatusEntity>
{
    private readonly BacchusDbContext _dbContext;

    public OrderStatusRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(OrderStatusEntity orderStatusEntity)
    {
        _dbContext.OrderStatuses.Add(orderStatusEntity);
    }

    public List<OrderStatusEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public OrderStatusEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(OrderStatusEntity orderStatusEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(OrderStatusEntity orderStatusEntity)
    {
        throw new NotImplementedException();
    }
}
