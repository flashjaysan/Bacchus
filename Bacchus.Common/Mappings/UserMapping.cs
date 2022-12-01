using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class UserMapping : Profile
{
    public UserMapping()
    {
        CreateMap<UserEntity, UserResource>();
        CreateMap<UserResource, UserEntity>();
    }
}
