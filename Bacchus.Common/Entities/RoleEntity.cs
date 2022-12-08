using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class RoleEntity : Entity
{
    public string Name { get; set; }
    public List<UserRoleEntity> UsersRoles { get; set; }

    public RoleEntity()
    {
        UsersRoles = new List<UserRoleEntity>();
    }
}
