using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class WineService : IWineService
{
    Task<WineResource> IWineService.Add(WineResource wineResource)
    {
        throw new NotImplementedException();
    }

    Task IWineService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<WineResource>> IWineService.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<WineResource> IWineService.GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    Task<WineResource> IWineService.Update(WineResource wineResource)
    {
        throw new NotImplementedException();
    }
}
