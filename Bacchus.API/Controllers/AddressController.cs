using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/addresses")]
public class AddressController : Controller
{
    private readonly IService<AddressResource> _addressService;

    public AddressController(IService<AddressResource> addressService)
    {
        _addressService = addressService;
    }
}
