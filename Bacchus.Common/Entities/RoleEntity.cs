using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class RoleEntity : Entity
{
    public string Name { get; set; }
    public List<UserRoleEntity> UserRoles { get; set; }

    public RoleEntity()
    {
        UserRoles = new List<UserRoleEntity>();
    }
}
