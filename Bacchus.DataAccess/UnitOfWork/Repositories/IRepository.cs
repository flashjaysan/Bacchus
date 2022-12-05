using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public interface IRepository<T>
{
    T GetOne(int id);
    List<T> GetAll();
    void Add(T t);
    void Update(T t);
    void Remove(T t);
}
