using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class OrderLineService : IOrderLineService
{
    Task<OrderLineResource> IOrderLineService.Add(OrderLineResource orderLineResource)
    {
        throw new NotImplementedException();
    }

    Task IOrderLineService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<OrderLineResource>> IOrderLineService.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<OrderLineResource> IOrderLineService.GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    Task<OrderLineResource> IOrderLineService.Update(OrderLineResource orderLineResource)
    {
        throw new NotImplementedException();
    }
}
