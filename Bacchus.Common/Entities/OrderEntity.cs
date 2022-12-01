namespace Bacchus.Common.Entities;

public class OrderEntity
{
    public int Id { get; set; }
    public UserEntity User { get; set; }
    public AddressEntity DeliveryAddress { get; set; }
    public OrderTypeEntity Type { get; set; }
    public OrderStatusEntity Status { get; set; }
    public List<OrderLineEntity> Lines { get; set; }

    public OrderEntity()
    {
        Lines = new List<OrderLineEntity>();
    }
}
