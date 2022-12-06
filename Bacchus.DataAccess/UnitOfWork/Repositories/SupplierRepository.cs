﻿using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class SupplierRepository : IRepository<SupplierEntity>
{
    private readonly BacchusDbContext _dbContext;

    public SupplierRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(SupplierEntity supplierEntity)
    {
        _dbContext.Suppliers.Add(supplierEntity);
    }

    public List<SupplierEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public SupplierEntity GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(SupplierEntity supplierEntity)
    {
        throw new NotImplementedException();
    }

    public void Update(SupplierEntity supplierEntity)
    {
        throw new NotImplementedException();
    }
}
