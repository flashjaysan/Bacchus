using Bacchus.Common.Core;

namespace Bacchus.Business;

public interface IService<T>
{
    Task<T> GetItemById(int id);
    Task<T> Add(Resource t);
    Task<T> Update(Resource t);
    Task Delete(int id);
    Task<List<T>> GetAll();
}
