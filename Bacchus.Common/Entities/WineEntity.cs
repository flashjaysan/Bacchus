namespace Bacchus.Common.Entities;

public class WineEntity
{
    public int Id { get; set; }
    public int Year { get; set; }
    public string Domain { get; set; }
    public string Description { get; set; }
    public Decimal SellingPrice { get; set; }
    public Decimal PurchasePrice { get; set; }
    public int Stock { get; set; }
    public WineFamilyEntity Family { get; set; }
    public GrapeVarietyEntity GrapeVariety { get; set; }
    public SupplierEntity Supplier { get; set; }
}
