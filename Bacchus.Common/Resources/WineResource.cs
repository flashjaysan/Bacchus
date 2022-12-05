using Bacchus.Common.Core;

namespace Bacchus.Common.Resources;

public class WineResource : Resource
{
    public int Year { get; set; }
    public string Domain { get; set; }
    public string Description { get; set; }
    public Decimal SellingPrice { get; set; }
    public Decimal PurchasePrice { get; set; }
    public int Stock { get; set; }
    public WineFamilyResource Family { get; set; }
    public GrapeVarietyResource GrapeVariety { get; set; }
    public SupplierResource Supplier { get; set; }
}
