using Bacchus.Common.Core;

namespace Bacchus.Common.Resources;

public class OrderWineResource : Resource
{
    public int OrderId { get; set; }
    public int WineId { get; set; }
    public OrderResource Order { get; set; }
    public WineResource Wine { get; set; }
    public int Quantity { get; set; }
}
