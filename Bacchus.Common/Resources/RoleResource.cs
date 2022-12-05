using Bacchus.Common.Core;

namespace Bacchus.Common.Resources;

public class RoleResource : Resource
{
    public string Name { get; set; }
    public List<UserRoleResource> UserRoles { get; set; }

    public RoleResource()
    {
        UserRoles = new List<UserRoleResource>();
    }
}
