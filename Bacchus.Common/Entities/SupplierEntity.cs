using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class SupplierEntity : Entity
{
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public int HomePhoneNumber { get; set; }
    public int MobilePhoneNumber { get; set; }
    public string Website { get; set; }
    public AddressEntity Address { get; set; }
    public List<SupplierWineEntity> SuppliersWines { get; set; }

    public SupplierEntity()
    {
        SuppliersWines = new List<SupplierWineEntity>();
    }
}
