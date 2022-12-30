using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class SupplierWineEntity : Entity
{
    public int SupplierId { get; set; }
    public int WineId { get; set; }
    public SupplierEntity Supplier { get; set; }
    public WineEntity Wine { get; set; }
    public Decimal Price { get; set; }
}
