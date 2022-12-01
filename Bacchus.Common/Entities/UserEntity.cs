namespace Bacchus.Common.Entities;

public class UserEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string EncryptedPassword { get; set; }
    public int HomePhoneNumber { get; set; }
    public int MobilePhoneNumber { get; set; }
    public List<RoleEntity> Roles { get; set; }
    public List<AddressEntity> Addresses { get; set; }
    public List<OrderEntity> Orders { get; set; }

    public UserEntity()
    {
        Roles = new List<RoleEntity>();
        Addresses = new List<AddressEntity>();
        Orders = new List<OrderEntity>();
    }
}
