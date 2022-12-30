using Bacchus.Common.Core;
using Bacchus.Common.Entities;

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
    public SupplierResource Supplier { get; set; }
    public List<OrderWineResource> OrdersWines { get; set; }
    public List<SupplierWineResource> SuppliersWines { get; set; }// table relier en many to many 

    public WineResource()
    {
        SuppliersWines = new List<SupplierWineResource>();
        OrdersWines = new List<OrderWineResource>();
    }
}
