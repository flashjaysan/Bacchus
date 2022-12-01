using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class WineMapping : Profile
{
    public WineMapping()
    {
        CreateMap<WineEntity, WineResource>();
        CreateMap<WineResource, WineEntity>();
    }
}
