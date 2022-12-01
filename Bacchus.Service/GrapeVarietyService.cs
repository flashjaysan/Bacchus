using Bacchus.Business;
using Bacchus.Common.Resources;

namespace Bacchus.Service;

public class GrapeVarietyService : IGrapeVarietyService
{
    Task<GrapeVarietyResource> IGrapeVarietyService.Add(GrapeVarietyResource grapeVarietyResource)
    {
        throw new NotImplementedException();
    }

    Task IGrapeVarietyService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<GrapeVarietyResource>> IGrapeVarietyService.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<GrapeVarietyResource> IGrapeVarietyService.GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    Task<GrapeVarietyResource> IGrapeVarietyService.Update(GrapeVarietyResource grapeVarietyResource)
    {
        throw new NotImplementedException();
    }
}
