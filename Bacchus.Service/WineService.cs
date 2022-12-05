using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class WineService : IService<WineResource>
{
    public Task<WineResource> Add(WineResource t)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<WineResource>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<WineResource> GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<WineResource> Update(WineResource t)
    {
        throw new NotImplementedException();
    }
}
