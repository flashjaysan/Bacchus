namespace Bacchus.Common.Entities;

public class SupplierEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public int HomePhoneNumber { get; set; }
    public int MobilePhoneNumber { get; set; }
    public string Website { get; set; }
    public AddressEntity Address { get; set; }
}
