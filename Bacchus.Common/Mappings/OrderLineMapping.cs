using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class OrderLineMapping : Profile
{
    public OrderLineMapping()
    {
        CreateMap<OrderWineEntity, OrderLineResource>();
        CreateMap<OrderLineResource, OrderWineEntity>();
    }
}
