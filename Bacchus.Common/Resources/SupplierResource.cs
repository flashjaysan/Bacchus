using Bacchus.Common.Core;

namespace Bacchus.Common.Resources;

public class SupplierResource : Resource
{
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public int HomePhoneNumber { get; set; }
    public int MobilePhoneNumber { get; set; }
    public string Website { get; set; }
    public AddressResource Address { get; set; }
}
