using Bacchus.Common.Core;

namespace Bacchus.Common.Resources;

public class UserResource : Resource
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string EncryptedPassword { get; set; }
    public int HomePhoneNumber { get; set; }
    public int MobilePhoneNumber { get; set; }
    public List<RoleResource> Roles { get; set; }
    public List<AddressResource> Addresses { get; set; }
    public List<OrderResource> Orders { get; set; }

    public UserResource()
    {
        Roles = new List<RoleResource>();
        Addresses = new List<AddressResource>();
        Orders = new List<OrderResource>();
    }
}
