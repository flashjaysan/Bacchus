namespace Bacchus.Common.Resources;

public class SupplierResource
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public int HomePhoneNumber { get; set; }
    public int MobilePhoneNumber { get; set; }
    public string Website { get; set; }
    public AddressResource Address { get; set; }
}
