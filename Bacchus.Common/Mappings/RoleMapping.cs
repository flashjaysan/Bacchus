using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class RoleMapping : Profile
{
    public RoleMapping()
    {
        CreateMap<RoleEntity, RoleResource>();
        CreateMap<RoleResource, RoleEntity>();
    }
}
