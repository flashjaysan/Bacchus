namespace Bacchus.Common.Resources;

public class RoleResource
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<UserRoleResource> UserRoles { get; set; }

    public RoleResource()
    {
        UserRoles = new List<UserRoleResource>();
    }
}
