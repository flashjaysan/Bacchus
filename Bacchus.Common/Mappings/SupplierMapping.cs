using AutoMapper;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;

namespace Bacchus.Common.Mappings;

public class SupplierMapping : Profile
{
    public SupplierMapping()
    {
        CreateMap<SupplierEntity, SupplierResource>();
        CreateMap<SupplierResource, SupplierEntity>();
    }
}
