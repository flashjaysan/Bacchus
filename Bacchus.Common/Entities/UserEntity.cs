using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class UserEntity : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string EncryptedPassword { get; set; }
    public int HomePhoneNumber { get; set; }
    public int MobilePhoneNumber { get; set; }
    public List<UserRoleEntity> UsersRoles { get; set; }
    public List<AddressEntity> Addresses { get; set; }
    public List<OrderEntity> Orders { get; set; }

    public UserEntity()
    {
        UsersRoles = new List<UserRoleEntity>();
        Addresses = new List<AddressEntity>();
        Orders = new List<OrderEntity>();
    }
}
