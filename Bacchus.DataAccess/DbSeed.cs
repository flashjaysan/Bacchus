using Bacchus.Common;
using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;

namespace Bacchus.DataAccess;

public class DbSeed
{
    public async Task SeedAsync(BacchusDbContext context)
    {
        using (context)
        {
            SeedRoleData<RoleEntity>(context);
            SeedRoleData<WineFamilyEntity>(context);
            await context.SaveChangesAsync();
        }
    }

    public void SeedRoleData<T>(BacchusDbContext context) where T : Enumeration
    {
        List<T> newSeeds = Enumeration.GetAll<T>().ToList();

        List<T> existingData = context.Set<T>().ToList();

        foreach (T seed in newSeeds)
        {
            if (existingData.Any(x => x.Id == seed.Id))
            {
                existingData.FirstOrDefault(x => x.Id == seed.Id).Update(seed);
            }
            else
            {
                context.Set<T>().Add(seed);
            }
        }
        // we don't delete the existing one that aren't in the seedfile because of possible FK reference logical delete possible or if cascade
        // delete if we are sure about the datas lost
    }
}
