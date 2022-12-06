using Bacchus.DataAccess.DbContext;

namespace Bacchus.DataAccess.UnitOfWork;

public interface IDbFactory
{
    BacchusDbContext BacchusDbContext { get; }
}
