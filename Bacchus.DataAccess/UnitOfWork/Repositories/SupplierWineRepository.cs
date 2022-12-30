using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class SupplierWineRepository : IRepository<SupplierWineEntity>
{
    private readonly BacchusDbContext _dbContext;

    public SupplierWineRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(SupplierWineEntity supplierWineEntity)
    {
        _dbContext.SuppliersWines.Add(supplierWineEntity);
    }

    public List<SupplierWineEntity> GetAll()
    {
        return _dbContext.SuppliersWines.ToList();
    }

    public SupplierWineEntity GetOne(int id)
    {
        return _dbContext.SuppliersWines.FirstOrDefault(supplierWine => supplierWine.Id == id);
    }

    public void Remove(SupplierWineEntity supplierWineEntity)
    {
        _dbContext.SuppliersWines.Remove(supplierWineEntity);
    }

    public void Update(SupplierWineEntity supplierWineEntity)
    {
        _dbContext.SuppliersWines.Update(supplierWineEntity);
    }
}
