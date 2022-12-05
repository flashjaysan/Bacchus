using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class OrderService : IService<OrderResource>
{
    public Task<OrderResource> Add(OrderResource t)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrderResource>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<OrderResource> GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<OrderResource> Update(OrderResource t)
    {
        throw new NotImplementedException();
    }
}
