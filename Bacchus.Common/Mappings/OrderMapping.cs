using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class OrderMapping : Profile
{
    public OrderMapping()
    {
        CreateMap<OrderEntity, OrderResource>();
        CreateMap<OrderResource, OrderEntity>()
        .ForMember(orderEntity => orderEntity.Id, option => option.Ignore());
    }
}
