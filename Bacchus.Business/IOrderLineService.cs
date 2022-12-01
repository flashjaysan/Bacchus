using Bacchus.Common.Resources;

namespace Bacchus.Business;

public interface IOrderLineService
{
    Task<OrderLineResource> GetItemById(int id);
    Task<OrderLineResource> Add(OrderLineResource orderLineResource);
    Task<OrderLineResource> Update(OrderLineResource orderLineResource);
    Task Delete(int id);
    Task<List<OrderLineResource>> GetAll();
}
