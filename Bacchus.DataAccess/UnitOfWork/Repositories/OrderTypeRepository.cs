﻿using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;

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
        throw new NotImplementedException();
    }

    public List<OrderTypeEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public OrderTypeEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(OrderTypeEntity orderTypeEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(OrderTypeEntity orderTypeEntity)
    {
        throw new NotImplementedException();
    }
}
