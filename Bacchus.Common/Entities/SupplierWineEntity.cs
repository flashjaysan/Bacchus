namespace Bacchus.Common.Entities;

public class SupplierWineEntity
{
    public int SupplierId { get; set; }
    public int WineId { get; set; }
    public SupplierEntity SupplierEntity { get; set; }
    public WineEntity WineEntity { get; set; }
}
