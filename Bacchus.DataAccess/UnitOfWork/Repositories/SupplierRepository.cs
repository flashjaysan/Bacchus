using Bacchus.Common.Entities;
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
        return _dbContext.Suppliers.ToList();
    }

    public SupplierEntity GetOne(int id)
    {
        return _dbContext.Suppliers.FirstOrDefault(supplier => supplier.Id == id);
    }

    public void Remove(SupplierEntity supplierEntity)
    {
        _dbContext.Suppliers.Remove(supplierEntity);
    }

    public void Update(SupplierEntity supplierEntity)
    {
        _dbContext.Suppliers.Update(supplierEntity);
    }
}
