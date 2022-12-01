using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class OrderService : IOrderService
{
    Task<OrderResource> IOrderService.Add(OrderResource orderResource)
    {
        throw new NotImplementedException();
    }

    Task IOrderService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<OrderResource>> IOrderService.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<OrderResource> IOrderService.GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    Task<OrderResource> IOrderService.Update(OrderResource orderResource)
    {
        throw new NotImplementedException();
    }
}
