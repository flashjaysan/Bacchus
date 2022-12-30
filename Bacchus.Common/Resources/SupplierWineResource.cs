using Bacchus.Common.Core;

namespace Bacchus.Common.Resources;

public class SupplierWineResource : Resource
{
    public int SupplierId { get; set; }
    public int WineId { get; set; }
    public SupplierResource Supplier { get; set; }
    public WineResource Wine { get; set; }
    public Decimal Price { get; set; }
}
