using Bacchus.Common.Core;

namespace Bacchus.Common.Resources;

public class OrderResource : Resource
{
    public int UserId { get; set; }
    public UserResource User { get; set; }
    public AddressResource DeliveryAddress { get; set; }
    public OrderTypeResource Type { get; set; }
    public OrderStatusResource Status { get; set; }
    public List<OrderWineResource> OrdersWines { get; set; }

    public OrderResource()
    {
        OrdersWines = new List<OrderWineResource>();
    }
}
