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
            await context.SaveChangesAsync();
        }
    }

    public void SeedRoleData<T>(BacchusDbContext context) where T : Enumeration
    {
        List<T> newSeeds = Enumeration.GetAll<T>().ToList();

        List<T> existingData = context.Set<T>().ToList();

        foreach (T newSeed in newSeeds)
        {
            // if the Id already exist we update
            if (existingData.Select(ed => ed.Id).Contains(newSeed.Id))
            {
                existingData.FirstOrDefault(ed => ed.Id == newSeed.Id).Update(newSeed);
            }
            // if the Id already exist we create a new one
            else
            {
                context.Add(newSeed);
            }
        }
        // we don't delete the existing one that aren't in the seedfile because of possible FK reference logical delete possible or if cascade
        // delete if we are sure about the datas lost
    }
}
