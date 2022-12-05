using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class UserService : IService<UserResource>
{
    public Task<UserResource> Add(UserResource t)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserResource>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<UserResource> GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UserResource> Update(UserResource t)
    {
        throw new NotImplementedException();
    }
}
