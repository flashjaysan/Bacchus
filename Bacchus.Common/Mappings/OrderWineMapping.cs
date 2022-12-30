using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class OrderWineMapping : Profile
{
    public OrderWineMapping()
    {
        CreateMap<OrderWineEntity, OrderWineResource>();
        CreateMap<OrderWineResource, OrderWineEntity>();
    }
}
