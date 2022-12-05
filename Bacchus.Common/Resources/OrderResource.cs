using Bacchus.Common.Core;

namespace Bacchus.Common.Resources;

public class OrderResource : Resource
{
    public UserResource User { get; set; }
    public AddressResource DeliveryAddress { get; set; }
    public OrderTypeResource Type { get; set; }
    public OrderStatusResource Status { get; set; }
    public List<OrderLineResource> Lines { get; set; }

    public OrderResource()
    {
        Lines = new List<OrderLineResource>();
    }
}
