namespace Bacchus.Common.Resources;

public class UserRoleResource
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int RoleId { get; set; }
    public UserResource User { get; set; }
    public RoleResource Role { get; set; }
}
