using Bacchus.Common.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bacchus.Common.Entities;

public class OrderEntity : Entity
{
    [ForeignKey("userId")]
    public int UserId { get; set; }
    public UserEntity User { get; set; }
    public int DeliveryAddressId { get; set; }
    public AddressEntity DeliveryAddress { get; set; }
    public int TypeId { get; set; }
    public OrderTypeEntity Type { get; set; }
    public int StatusId { get; set; }
    public OrderStatusEntity Status { get; set; }
    public List<OrderWineEntity> OrdersWines { get; set; }

    public OrderEntity()
    {
        OrdersWines = new List<OrderWineEntity>();
    }
}
