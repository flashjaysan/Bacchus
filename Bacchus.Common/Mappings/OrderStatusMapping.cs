using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class OrderStatusMapping : Profile
{
    public OrderStatusMapping()
    {
        CreateMap<OrderStatusEntity, OrderStatusResource>();
        CreateMap<OrderStatusResource, OrderStatusEntity>();
    }
}
