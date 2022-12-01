using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class WineFamilyService : IWineFamilyService
{
    Task<WineFamilyResource> IWineFamilyService.Add(WineFamilyResource wineFamilyResource)
    {
        throw new NotImplementedException();
    }

    Task IWineFamilyService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<WineFamilyResource>> IWineFamilyService.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<WineFamilyResource> IWineFamilyService.GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    Task<WineFamilyResource> IWineFamilyService.Update(WineFamilyResource wineFamilyResource)
    {
        throw new NotImplementedException();
    }
}
