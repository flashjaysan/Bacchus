using Bacchus.Common.Resources;

namespace Bacchus.Business;

public interface ISupplierService
{
    Task<SupplierResource> GetItemById(int id);
    Task<SupplierResource> Add(SupplierResource supplierResource);
    Task<SupplierResource> Update(SupplierResource supplierResource);
    Task Delete(int id);
    Task<List<SupplierResource>> GetAll();
}
