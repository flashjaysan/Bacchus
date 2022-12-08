using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class OrderWineEntity : Entity
{
    public int OrderId { get; set; }
    public int WineId { get; set; }
    public OrderEntity OrderEntity { get; set; }
    public WineEntity WineEntity { get; set; }
    public int Quantity { get; set; }
}
