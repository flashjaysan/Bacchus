using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class OrderLineService : IService<OrderLineResource>
{
    public Task<OrderLineResource> Add(OrderLineResource t)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrderLineResource>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<OrderLineResource> GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<OrderLineResource> Update(OrderLineResource t)
    {
        throw new NotImplementedException();
    }
}
