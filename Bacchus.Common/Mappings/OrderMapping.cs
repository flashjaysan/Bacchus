using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.Common.Resources.Order;

namespace Bacchus.Common.Mappings;

public class OrderMapping : Profile
{
    public OrderMapping()
    {
        CreateMap<OrderEntity, OrderResource>();
        CreateMap<OrderResource, OrderEntity>();
        CreateMap<OrderSaveResource, OrderEntity>();
    }
}
