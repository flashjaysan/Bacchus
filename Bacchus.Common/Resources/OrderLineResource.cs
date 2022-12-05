using Bacchus.Common.Core;

namespace Bacchus.Common.Resources;

public class OrderLineResource : Resource
{
    public WineResource Wine { get; set; }
    public int Quantity { get; set; }
}
