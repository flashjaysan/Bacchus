using Bacchus.Common.Resources;

namespace Bacchus.Business;

public interface IWineFamilyService
{
    Task<WineFamilyResource> GetItemById(int id);
    Task<WineFamilyResource> Add(WineFamilyResource wineFamilyResource);
    Task<WineFamilyResource> Update(WineFamilyResource wineFamilyResource);
    Task Delete(int id);
    Task<List<WineFamilyResource>> GetAll();
}
