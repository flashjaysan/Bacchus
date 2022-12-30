using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class UserRoleMapping : Profile
{
    public UserRoleMapping()
    {
        CreateMap<UserRoleEntity, UserRoleResource>();
        CreateMap<UserRoleResource, UserRoleEntity>();
    }
}
