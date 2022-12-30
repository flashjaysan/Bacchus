using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class WineEntity : Entity
{
    public int Year { get; set; }
    public string Domain { get; set; }
    public string Description { get; set; }
    public Decimal SellingPrice { get; set; }
    public Decimal PurchasePrice { get; set; }
    public int Stock { get; set; }
    public WineFamilyEntity Family { get; set; }
    public SupplierEntity Supplier { get; set; } //table wine relier en one to many ici 
    public List<OrderWineEntity> OrdersWines { get; set; }
    public List<SupplierWineEntity> SuppliersWines { get; set; }// table relier en many to many 

    public WineEntity()
    {
        SuppliersWines = new List<SupplierWineEntity>();
        OrdersWines = new List<OrderWineEntity>();
    }
}
