namespace Bacchus.Common.Entities;

public class RoleEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<UserRoleEntity> UserRoles { get; set; }

    public RoleEntity()
    {
        UserRoles = new List<UserRoleEntity>();
    }
}
