using Bacchus.Common.Core;
using Bacchus.Common.Entities;

namespace Bacchus.Common.Resources;

public class SupplierResource : Resource
{
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public int HomePhoneNumber { get; set; }
    public int MobilePhoneNumber { get; set; }
    public string Website { get; set; }
    public AddressResource Address { get; set; }
    public List<SupplierWineResource> SuppliersWines { get; set; }

    public SupplierResource()
    {
        SuppliersWines = new List<SupplierWineResource>();
    }
}
