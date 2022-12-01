using Bacchus.Common.Resources;

namespace Bacchus.Business;

public interface IGrapeVarietyService
{
    Task<GrapeVarietyResource> GetItemById(int id);
    Task<GrapeVarietyResource> Add(GrapeVarietyResource grapeVarietyResource);
    Task<GrapeVarietyResource> Update(GrapeVarietyResource grapeVarietyResource);
    Task Delete(int id);
    Task<List<GrapeVarietyResource>> GetAll();
}
