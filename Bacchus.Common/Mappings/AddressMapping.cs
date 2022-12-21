using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class AddressMapping : Profile
{
    public AddressMapping()
    {
        CreateMap<AddressEntity, AddressResource>();
        CreateMap<AddressResource, AddressEntity>()
        .ForMember(addressEntity => addressEntity.Id, option => option.Ignore());
    }
}
