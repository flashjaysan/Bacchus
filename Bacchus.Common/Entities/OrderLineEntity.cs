using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class OrderLineEntity : Entity
{
    public WineEntity Wine { get; set; }
    public int Quantity { get; set; }
}
