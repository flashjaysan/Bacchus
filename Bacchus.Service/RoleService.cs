using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class RoleService : IRoleService
{
    Task<RoleResource> IRoleService.Add(RoleResource roleResource)
    {
        throw new NotImplementedException();
    }

    Task IRoleService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<RoleResource>> IRoleService.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<RoleResource> IRoleService.GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    Task<RoleResource> IRoleService.Update(RoleResource roleResource)
    {
        throw new NotImplementedException();
    }
}
