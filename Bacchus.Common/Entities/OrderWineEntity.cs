using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class OrderWineEntity : Entity
{
    public int OrderId { get; set; }
    public int WineId { get; set; }
    public OrderEntity Order { get; set; }
    public WineEntity Wine { get; set; }
    public int Quantity { get; set; }
}
