using Bacchus.Common.Resources;

namespace Bacchus.Business;

public interface IAddressService
{
    Task<AddressResource> GetItemById(int id);
    Task<AddressResource> Add(AddressResource addressResource);
    Task<AddressResource> Update(AddressResource addressResource);
    Task Delete(int id);
    Task<List<AddressResource>> GetAll();
}
