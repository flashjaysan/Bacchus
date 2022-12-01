using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class UserService : IUserService
{
    Task<UserResource> IUserService.Add(UserResource userResource)
    {
        throw new NotImplementedException();
    }

    Task IUserService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<UserResource>> IUserService.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<UserResource> IUserService.GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    Task<UserResource> IUserService.Update(UserResource userResource)
    {
        throw new NotImplementedException();
    }
}
