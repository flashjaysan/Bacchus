using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class OrderEntity : Entity
{
    public UserEntity User { get; set; }
    public AddressEntity DeliveryAddress { get; set; }
    public OrderTypeEntity Type { get; set; }
    public OrderStatusEntity Status { get; set; }
    public List<OrderWineEntity> OrdersWines { get; set; }

    public OrderEntity()
    {
        OrdersWines = new List<OrderWineEntity>();
    }
}
