using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class SupplierWineMapping : Profile
{
    public SupplierWineMapping()
    {
        CreateMap<SupplierWineEntity, SupplierWineResource>();
        CreateMap<SupplierWineResource, SupplierWineEntity>();
    }
}
