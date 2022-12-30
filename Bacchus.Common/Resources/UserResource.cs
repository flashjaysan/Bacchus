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
    public List<UserRoleResource> UsersRoles { get; set; }
    public List<AddressResource> Addresses { get; set; }
    public List<OrderResource> Orders { get; set; }

    public UserResource()
    {
        UsersRoles = new List<UserRoleResource>();
        Addresses = new List<AddressResource>();
        Orders = new List<OrderResource>();
    }
}
