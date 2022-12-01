using Bacchus.Common.Resources;

namespace Bacchus.Business;

public interface IRoleService
{
    Task<RoleResource> GetItemById(int id);
    Task<RoleResource> Add(RoleResource roleResource);
    Task<RoleResource> Update(RoleResource roleResource);
    Task Delete(int id);
    Task<List<RoleResource>> GetAll();
}
