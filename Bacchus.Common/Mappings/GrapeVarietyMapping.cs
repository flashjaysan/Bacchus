using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class GrapeVarietyMapping : Profile
{
    public GrapeVarietyMapping()
    {
        CreateMap<GrapeVarietyEntity, GrapeVarietyResource>();
        CreateMap<GrapeVarietyResource, GrapeVarietyEntity>();
    }
}
