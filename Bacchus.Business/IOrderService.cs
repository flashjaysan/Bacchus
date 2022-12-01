using Bacchus.Common.Resources;

namespace Bacchus.Business;

public interface IOrderService
{
    Task<OrderResource> GetItemById(int id);
    Task<OrderResource> Add(OrderResource orderResource);
    Task<OrderResource> Update(OrderResource orderResource);
    Task Delete(int id);
    Task<List<OrderResource>> GetAll();
}
