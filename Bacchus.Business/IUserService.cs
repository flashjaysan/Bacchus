using Bacchus.Common.Resources;

namespace Bacchus.Business;

public interface IUserService
{
    Task<UserResource> GetItemById(int id);
    Task<UserResource> Add(UserResource userResource);
    Task<UserResource> Update(UserResource userResource);
    Task Delete(int id);
    Task<List<UserResource>> GetAll();
}
