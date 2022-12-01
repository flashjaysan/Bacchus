using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class AddressService : IAddressService
{
    Task<AddressResource> IAddressService.Add(AddressResource addressResource)
    {
        throw new NotImplementedException();
    }

    Task IAddressService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<AddressResource>> IAddressService.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<AddressResource> IAddressService.GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    Task<AddressResource> IAddressService.Update(AddressResource addressResource)
    {
        throw new NotImplementedException();
    }
}
