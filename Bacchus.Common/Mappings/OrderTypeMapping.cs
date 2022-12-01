using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class OrderTypeMapping : Profile
{
    public OrderTypeMapping()
    {
        CreateMap<OrderTypeEntity, OrderTypeResource>();
        CreateMap<OrderTypeResource, OrderTypeEntity>();
    }
}
