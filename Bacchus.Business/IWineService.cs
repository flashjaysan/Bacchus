using Bacchus.Common.Resources;

namespace Bacchus.Business;

public interface IWineService
{
    Task<WineResource> GetItemById(int id);
    Task<WineResource> Add(WineResource wineResource);
    Task<WineResource> Update(WineResource wineResource);
    Task Delete(int id);
    Task<List<WineResource>> GetAll();
}
