using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class SupplierService : ISupplierService
{
    Task<SupplierResource> ISupplierService.Add(SupplierResource supplierResource)
    {
        throw new NotImplementedException();
    }

    Task ISupplierService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<SupplierResource>> ISupplierService.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<SupplierResource> ISupplierService.GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    Task<SupplierResource> ISupplierService.Update(SupplierResource supplierResource)
    {
        throw new NotImplementedException();
    }
}
