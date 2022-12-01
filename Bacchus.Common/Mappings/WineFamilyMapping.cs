using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class WineFamilyMapping : Profile
{
    public WineFamilyMapping()
    {
        CreateMap<WineFamilyEntity, WineFamilyResource>();
        CreateMap<WineFamilyResource, WineFamilyEntity>();
    }
}
