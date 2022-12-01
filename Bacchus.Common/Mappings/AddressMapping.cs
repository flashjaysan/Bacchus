using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using System.Data;

namespace Bacchus.Common.Mappings;

public class AddressMapping : Profile
{
    public AddressMapping()
    {
        CreateMap<AddressEntity, AddressResource>();
        CreateMap<AddressResource, AddressEntity>();
    }
}
