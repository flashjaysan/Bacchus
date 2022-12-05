namespace Bacchus.DataAccess.UnitOfWork;

public interface IUnitOfWork
{
    Task SaveIntoDbContextAsync();
}
