namespace Bacchus.Common.Resources;

public class OrderResource
{
    public int Id { get; set; }
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
